# 移植ESP32SPI驱动至rtthread教程


本文是博主移植驱动工作的总结，详细介绍了移植过程以及遇到的问题及其解决方案，希望对各位有帮助。同时，代码已进入[RT-Thread主线](https://github.com/RT-Thread/rt-thread/pull/9513)。博文同时发表在个人博客[wumingzi.top](wumingzi.top)

<!-- more -->

# 移植ESP32SPI驱动至RT-Thread

本文主要使用、查阅了以下资料：
* 参考书籍 RT-Thread设备驱动开发指南，ESP32官方文档
* 硬件 ESP32-C3-DevKitM-1，W25Q64

## 系统平台搭建  

具体的硬件连线不必多说，参考[ESP32C3官方开发板的原理图](https://docs.espressif.com/projects/esp-dev-kits/zh_CN/latest/esp32c3/esp32-c3-devkitm-1/user_guide.html#id9)即可，交叉编译环境可以参考博主的这篇文章[ESP32C3环境搭建教程](https://club.rt-thread.org/ask/article/cf9ff0733112d936.html)，代码编辑器我使用了vscode+clang的搭配方式，不采用微软的C/C++插件的原因是在编写驱动时vscode发生过多次闪退的情况，并且代码提示和高亮补全残缺，相关配置可自行参考网上

## 代码参考  

我们可以参考其他芯片的SPI驱动代码来编写，个人参考了GD32和STM32的代码，GD32的驱动代码会简单很多，STM32会更复杂一些

## 修改Kconfig与SConscript文件  

Kconfig指定了系统资源，使得我们可以通过menuconfig来选择配置系统。Kconfig原理可以看[官方文档](https://www.rt-thread.org/document/site/#/development-tools/build-config-system/Kconfig?id=kconfig)，简而言之，我们可以通过menuconfig的tui界面来配置Kconfig从而生成.config文件，而后再由系统解析.config文件最后生成rtconfig.h文件来指定系统宏的值从而配置系统。但当前Kconfg并不支持SPI驱动，因此我们需要新增Kconfig选项。 

Kconfig的风格与厂商，开发者个人相关。例如有的厂商会习惯将引脚配置项放在板上菜单中，并将功能配置项放在片上外设菜单中 ，而有的厂商会将两者都混放在片上外设菜单或BSP菜单中。前者代表是ESP32和GD32，后者代表是STM32

新增的代码如下
```Kconfig
menu "Onboard Peripheral Drivers"
···
config RT_BSP_SPI_CS_PIN
        int "SPI GPIO PIN SET"
        default 10 if BSP_BOARD_LUATOS_ESP32C3
        depends on BSP_USING_SPI2
···

menu "On-chip Peripheral Drivers"
···
menuconfig BSP_USING_SPI
        bool "Enable SPI"
        default n
        select RT_USING_SPI
        if BSP_USING_SPI
            config BSP_USING_SPI2
                bool "Enable SPI2"
                default n
        endif 
···
```
下面是参数的意义：
RT_USING_SPI：是否添加设备驱动框架代码到工程中
BSP_USING_SPI：是否添加总线设备驱动代码到工程中
BSP_USING_SPIx：添加哪个总线设备驱动代码到工程中

scons脚本类似于cmake、make等工具，是一款由python编写的编译工具，详见[官方文档](https://www.rt-thread.org/document/site/#/development-tools/build-config-system/SCons?id=_2-scons-简介)，我们要做的只是添加新编写的spi驱动文件到driver/SConscript里就可以了
```python
···
if GetDepend('BSP_USING_SPI'):
    src += ['drv_spi.c']
···
```
对于头文件，我们不需要引入，因为头文件搜索路径已经在脚本里指明为当前文件夹了
```python
import os
from building import *

cwd = GetCurrentDir()    //获取头文件路径
src = ['board.c']

//CPPPATH不是C++的源文件路径，而是C头文件的搜索路径
CPPPATH = [cwd]

···

group = DefineGroup('Drivers', src, depend = [''], CPPPATH = CPPPATH)

Return('group')
```

## 编写驱动文件  

驱动编写的方法策略：
首先spi驱动编写并不困难，我们只需要参考其他spi驱动编写情况将ESP32的驱动用RT-Thread内核api包装起来即可，这与设计模式中的适配器思想很类似

简单起见，我们先参考GD32的spi驱动代码，代码位于`bsp/gd32/risc-v/libraries/gd32_drivers/drv_spi.c`

映入眼帘的就是`gd32_spi`类型的结构体数组`spi_bus_obj[]`。我们可以看到，gd32_spi就是gd32官方提供的结构体，内部的`SPIx`，`GPIO_PIN_x`为宏定义的内存地址，指向了gd32对应外设的寄存器，由于spi片选引脚需要应用层来指定，因此结构体内只有3个GPIO宏
```c
static const struct gd32_spi spi_bus_obj[] = {

#ifdef BSP_USING_SPI0
    {
        SPI0,
        "spi0",
        RCU_SPI0,
        RCU_GPIOA,
        &spi_bus0,
        GPIOA,
        GPIO_PIN_5,
        GPIO_PIN_6,
        GPIO_PIN_7,
    }
#endif /* BSP_USING_SPI0 */

#ifdef BSP_USING_SPI1
    {
        SPI1,
        "spi1",
        RCU_SPI1,
        RCU_GPIOB,
        &spi_bus1,
        GPIOB,
        GPIO_PIN_12,
        GPIO_PIN_14,
        GPIO_PIN_15,
    }
#endif /* BSP_USING_SPI1 */

#ifdef BSP_USING_SPI2
    {
        SPI2,
        "spi2",
        RCU_SPI2,
        RCU_GPIOB,
        &spi_bus2,
        GPIOB,
        GPIO_PIN_3,
        GPIO_PIN_4,
        GPIO_PIN_5,
    }
#endif /* BSP_USING_SPI2 */
};

// bsp/gd32/risc-v/libraries/gd32_drivers/drv_spi.h
struct gd32_spi
{
    uint32_t spi_periph;
    char *bus_name;
    rcu_periph_enum spi_clk;
    rcu_periph_enum gpio_clk;
    struct rt_spi_bus *spi_bus;
    uint32_t spi_port;
    uint16_t sck_pin;
    uint16_t miso_pin;
    uint16_t mosi_pin;
};
```
下面是GPIO相关的宏定义
```c
#include "gd32f10x.h"

/* GPIOx(x=A,B,C,D,E,F,G) definitions */
#define GPIOA                      (GPIO_BASE + 0x00000000U)
#define GPIOB                      (GPIO_BASE + 0x00000400U)

···
bsp/gd32/arm/libraries/GD32F10x_Firmware_Library/CMSIS/GD/GD32F10x/Include/gd32f10x.h

/* bit operations */
#define REG32(addr)                  (*(volatile uint32_t *)(uint32_t)(addr))
#define REG16(addr)                  (*(volatile uint16_t *)(uint32_t)(addr))
#define REG8(addr)                   (*(volatile uint8_t *)(uint32_t)(addr))
#define BIT(x)                       ((uint32_t)((uint32_t)0x01U<<(x)))
#define BITS(start, end)             ((0xFFFFFFFFUL << (start)) & (0xFFFFFFFFUL >> (31U - (uint32_t)(end))))
#define GET_BITS(regval, start, end) (((regval) & BITS((start),(end))) >> (start))

#define APB2_BUS_BASE         ((uint32_t)0x40010000U)        /*!< apb2 base address                */
#define GPIO_BASE             (APB2_BUS_BASE + 0x00000800U)  /*!< GPIO base address                */
```
`spi_bus_obj`写成结构体数组的含义也很好懂：支持未指定数量的spi的外设，并利用宏进行编译期的内存优化。而这里的宏就是我们在修改Kconfig配置时的添加的宏。值得主义的是`spi_bus_obj`结构体中含有`rt_spi_bus`变量，这一变量实际上是将这个结构体挂载到内核的挂载点，一个合理的推测是可以利用类似linux内核中`container_of`宏来通过`rt_spi_bus`获取结构体首地址，这样就可以取得所需数据了

这里也可以看到结构体数组的名称是`spi_bus_obj`，这里的bus指的就是可以控制多个外设的控制器，有时也被称为`controller`，`adapter`。当然，他们之间的也有一些区别，这里按下不表

之后是最重要的部分，即初始化，配置以及传输函数，在这里我们简化并重新排序代码块：
```c
static struct rt_spi_ops gd32_spi_ops =
{
    .configure = spi_configure,
    .xfer = spixfer,
};

static void gd32_spi_init(struct gd32_spi *gd32_spi)
{
    /* enable SPI clock */
    rcu_periph_clock_enable(gd32_spi->spi_clk);
    rcu_periph_clock_enable(gd32_spi->gpio_clk);

    /* Init SPI SCK MOSI */
    gpio_init(gd32_spi->spi_port, GPIO_MODE_AF_PP, GPIO_OSPEED_50MHZ, gd32_spi->sck_pin | gd32_spi->mosi_pin);

    /* Init SPI MISO */
    gpio_init(gd32_spi->spi_port, GPIO_MODE_IN_FLOATING, GPIO_OSPEED_50MHZ, gd32_spi->miso_pin);

}

static rt_err_t spi_configure(struct rt_spi_device* device,
                          struct rt_spi_configuration* configuration)
{
    ···
    gd32_spi_init(spi_device);
    /* configuration something */
    
    ···
    max_hz = configuration->max_hz;
    if(configuration->mode & RT_SPI_MSB)
    {
        spi_init_struct.endian = SPI_ENDIAN_MSB;
    }
    
    spi_init_struct.trans_mode = SPI_TRANSMODE_FULLDUPLEX;
    spi_init_struct.device_mode = SPI_MASTER;
    spi_init_struct.nss = SPI_NSS_SOFT;
    ···
    
    spi_init(spi_periph, &spi_init_struct);
    /* Enable SPI_MASTER */
    spi_enable(spi_periph);
    ···
}

static rt_uint32_t spixfer(struct rt_spi_device* device, struct rt_spi_message* message)
{

    struct rt_spi_bus * gd32_spi_bus = (struct rt_spi_bus *)device->bus;
    struct gd32_spi *spi_device = (struct gd32_spi *)gd32_spi_bus->parent.user_data;
    struct rt_spi_configuration * config = &device->config;
    struct gd32_spi_cs * gd32_spi_cs = device->parent.user_data;
    uint32_t spi_periph = spi_device->spi_periph;

    /* take CS */
    if(message->cs_take)
    {
        gpio_bit_reset(gd32_spi_cs->GPIOx, gd32_spi_cs->GPIO_Pin);
        LOG_D("spi take cs\n");
    }
    
    ···
    /* choose transfer ways */
    ···
    
    while(RESET == spi_i2s_flag_get(spi_periph, SPI_FLAG_TBE));
    // Send the byte
    spi_i2s_data_transmit(spi_periph, data);

    //Wait until a data is received
    while(RESET == spi_i2s_flag_get(spi_periph, SPI_FLAG_RBNE));
    // Get the received data
    data = spi_i2s_data_receive(spi_periph);

    if(message->cs_release)
    {
        gpio_bit_set(gd32_spi_cs->GPIOx, gd32_spi_cs->GPIO_Pin);
        LOG_D("spi release cs\n");
    }
    
    ···
    /* do something */
    ···
}

int rt_hw_spi_init(void)
{
    int result = 0;
    int i;

    for (i = 0; i < sizeof(spi_bus_obj) / sizeof(spi_bus_obj[0]); i++)
    {
        spi_bus_obj[i].spi_bus->parent.user_data = (void *)&spi_bus_obj[i];

        result = rt_spi_bus_register(spi_bus_obj[i].spi_bus, spi_bus_obj[i].bus_name, &gd32_spi_ops);

        RT_ASSERT(result == RT_EOK);

        LOG_D("%s bus init done", spi_bus_obj[i].bus_name);
    }

    return result;
}

INIT_BOARD_EXPORT(rt_hw_spi_init);
```
首先看代码最后的`rt_hw_spi_init`，这个函数执行注册过程，即将`spi_bus_obj`中
若干个`gd32_spi`结构体的`rt_spi_bus`注册到内核中。并在最后附上`INIT_BOARD_EXPORT(rt_hw_spi_init);`来表示在板级初始化时注册

但是仅仅注册了结构体并不能使用驱动。想想裸机开发就知道了，我们在裸机开发中的过程首先需要配置相关结构体，然后初始化相关外设，最后再使用外设。我们在RTOS中也需要上述过程，但只不过这些过程被包装成了与OS相关的函数罢了

所谓的OS的相关函数指的就是`static struct rt_spi_ops gd32_spi_ops`函数指针结构体，其内部包含了若干个函数指针，我们只需要将这些函数指针指向我们给OS提供的函数，OS就可以调用了。但需要注意的是，尽管我们给OS提供的函数可以任意给定名称，但实现相关操作的函数并不能任意赋值给函数指针，因为这些函数指针指向的内容是是具名的，有固定用途的内核方法

接下来我们看看注册到内核的函数做了什么：
首先是`spi_configure`，在其内部首先调用`gd32_spi_init`进行初始化，而`gd32_spi_init`做的事就是开启相关时钟，配置相关GPIO引脚。当初始化完成后会进行默认配置，这里的配置会调用应用层传过来的配置结构体，尽管大多数参数可以自定义，但还有一些参数是不能的，典型的是spi主从模式选择和，单双工模式选择上。而在其内部调用的是gd32的库函数

之后是`spixfer`，其内部调用gd32标准库的spi传输函数`spi_i2s_flag_get`。并在传输过程前后添加`gpio_bit_set`以根据片选引脚控制通讯的开始与结束

我们再参考一下stm32的spi驱动(这里就不放源码了)，两者区别在于，stm32的代码会远远长于gd32。造成在这种结果的原因是，stm32支持的stm32芯片系列很多，支持spi外设也很多，需要更多的宏开关和条件分支来配置参数，并且stm32的配置更灵活，这又带来了更多的条件分支和更多参数组合。例如支持中断接收以及dma接收，这就意味着需要重写中断函数，要增加检测错误代码以及内存对齐代码。但是其本质依然是在相关函数中通过调用stm32库函数实现功能并注册给内核

接下来我们编写自己的spi驱动
首先需要给出整体框架和需要用到的变量、数据类型
```c
#include <rtthread.h>
#include <rtdevice.h>
#include "drv_spi.h"

static struct rt_spi_bus spi_bus2;

static spi_device_handle_t spi;

static spi_bus_config_t buscfg;

static struct esp32_spi spi_bus_obj[] = {
#ifdef BSP_USING_SPI2
    {
        .bus_name = "spi2",
        .spi_bus = &spi_bus2,
        .esp32_spi_bus_cfg = &buscfg,
    },
#endif /* BSP_USING_SPI2 */
};

/* private rt-thread spi ops function */
static rt_err_t spi_configure(struct rt_spi_device* device, struct rt_spi_configuration* configuration);
static rt_ssize_t spixfer(struct rt_spi_device* device, struct rt_spi_message* message);

static struct rt_spi_ops esp32_spi_ops =
{
    .configure = spi_configure,
    .xfer = spixfer,
};

static void esp32_spi_init(struct esp32_spi *esp32_spi)
{
    
}

static void spi_pin_mode(rt_base_t pin)
{
    
}

static rt_err_t spi_configure(struct rt_spi_device* device,
                          struct rt_spi_configuration* configuration)
{
    
}

static rt_ssize_t spixfer(struct rt_spi_device* device, struct rt_spi_message* message)
{
    
}

rt_err_t rt_hw_spi_device_attach(const char *bus_name, const char *device_name, rt_base_t cs_pin)
{
    
}

int rt_hw_spi_init(void)
{
    
}

INIT_BOARD_EXPORT(rt_hw_spi_init);
```
相比gd32的驱动代码，这里仿造stm32增加了`rt_hw_spi_device_attach`函数以支持硬件绑定功能，此函数会将spi设备绑定到spi总线上并指定片选引脚，使用此函数指定片选引脚能够避免不同bsp的上层应用对片选引脚操作不统一的问题
但别忘了，这里我们需要将`rt_spi_bus`包含进我们自定义的结构体`esp32_spi`中，这个结构体位于头文件中
```c
// bsp/ESP32_C3/drivers/drv_spi.h
struct esp32_spi
{
    char *bus_name;
    struct rt_spi_bus *spi_bus;
    spi_bus_config_t* esp32_spi_bus_cfg;    //这里是esp32spi库中的结构体
};
```

而后我们从`rt_hw_spi_init`开始编写代码，这个函数负责将操作函数和总线名称注册进内核
```c
int rt_hw_spi_init(void)
{
    int result = 0;

    spi_bus_obj[0].spi_bus->parent.user_data = (void *)&spi_bus_obj[0];
    result = rt_spi_bus_register(spi_bus_obj[0].spi_bus, spi_bus_obj[0].bus_name, &esp32_spi_ops);

    RT_ASSERT(result == RT_EOK);

    LOG_D("%s bus init done", spi_bus_obj[i].bus_name);

    return result;
}
```
之后编写初始化和配置代码。这里我们代码的使用方式是在应用层直接调用初始化代码就可以工作，那么我们直接在初始化代码中调用配置代码，在配置代码中完成缺省配置即可
```c
static void esp32_spi_init(struct esp32_spi *esp32_spi)
{
    spi_configure(NULL,NULL);
}

static rt_err_t spi_configure(struct rt_spi_device* device,
                          struct rt_spi_configuration* configuration)
{
    static spi_bus_config_t buscfg =
    {
        .miso_io_num=SPI2_IOMUX_PIN_NUM_MISO,              /*MISO*/
        .mosi_io_num=SPI2_IOMUX_PIN_NUM_MOSI,              /*MOSI*/
        .sclk_io_num=SPI2_IOMUX_PIN_NUM_CLK,               /*CLK*/
        .quadwp_io_num=-1,                      /*不使用*/
        .quadhd_io_num=-1,                      /*不使用*/
        .max_transfer_sz=4092                    /*最大传送数据长度*/
    };

    esp_err_t err = spi_bus_initialize(SPI2_HOST, &buscfg, SPI_DMA_CH_AUTO);
    ESP_ERROR_CHECK(err);

    static spi_device_interface_config_t devcfg={
        .clock_speed_hz = SPI_MASTER_FREQ_8M,
        .mode = 0,
        .spics_io_num = RT_BSP_SPI_CS_PIN,
        .queue_size = 7,
    };

    err = spi_bus_add_device(SPI2_HOST, &devcfg, &spi);
    ESP_ERROR_CHECK(err);

    spi_bus_obj[0].bus_name = "spi2";
    spi_bus_obj[0].spi_bus = &spi_bus2;
    spi_bus_obj[0].esp32_spi_bus_cfg = &buscfg;

    return RT_EOK;
};
```
后期我们可以添加自定义配置功能，这里的重点是调用esp32spi库中的`spi_bus_initialize`函数来进行初始化
最后实现`spixfer`函数
```c
static rt_ssize_t spixfer(struct rt_spi_device* device, struct rt_spi_message* message)
{

    RT_ASSERT(device != NULL);
    RT_ASSERT(message != NULL);

    static spi_transaction_t trans;

    trans.tx_buffer = message->send_buf;
    trans.rx_buffer = message->recv_buf;
    trans.length = message->length;
    trans.rxlength = message->length;

    spi_device_acquire_bus(spi, portMAX_DELAY);
    esp_err_t err = spi_device_polling_transmit(spi, &trans);

    spi_device_release_bus(spi);

    ESP_ERROR_CHECK(err);
    return RT_EOK;
};
```
这里的重点是调用乐鑫官方库的`spi_device_polling_transmit`函数来传输数据，按文档推荐，前后添加获取，释放总线操作以提高稳定性
最后实现`rt_hw_spi_device_attach`函数，这个函数会将板载外设挂载到片上的spi总线上
```c
rt_err_t rt_hw_spi_device_attach(const char *bus_name, const char *device_name, rt_base_t cs_pin)
{
    RT_ASSERT(bus_name != RT_NULL);
    RT_ASSERT(device_name != RT_NULL);

    rt_err_t result;rt_device_t busp = RT_NULL;
    struct rt_spi_device *spi_device;

    /* attach the device to spi bus*/
    spi_device = (struct rt_spi_device *)rt_malloc(sizeof(struct rt_spi_device));
    RT_ASSERT(spi_device != RT_NULL);

    result = rt_spi_bus_attach_device(spi_device, device_name, bus_name, (void *)cs_pin);

    if (result != RT_EOK)
    {
        LOG_E("%s attach to %s faild, %d\n", device_name, bus_name, result);
    }

    RT_ASSERT(result == RT_EOK);

    LOG_D("%s attach to %s done", device_name, bus_name);

    return result;
}
```
核心操作是`rt_spi_bus_attach_device`，会将设备名称，总线名称，片选引脚绑定到一起。当然，我们也可以不实现这个函数，但是就需要应用层手动调用`rt_spi_bus_attach_device`进行设备总线绑定了



## 测试驱动

最后的测试代码参考于《RT-Thread设备驱动开发指南》，代码比较简单：
```c
 	
void spi_w25q_sample(void)	
{	
    rt_hw_spi_device_attach(SPI_BUS_NAME, W25Q_SPI_DEVICE_NAME, GPIO_NUM_10 );
    struct rt_spi_device *spi_w25q;
    struct rt_spi_configuration cfg;
    
    rt_uint8_t w25x_read_id[5] = {0x9f, 0xff, 0xff, 0x00, 0xff};
    rt_uint8_t id[5] = {0x00,0x00,0x00,0x00,0x00,};
    
    spi_w25q = (struct rt_spi_device*)rt_device_find(W25Q_SPI_DEVICE_NAME);
    
    if(!spi_w25q)
    {
        rt_kprintf("spi asmple run failed! can't find %s device\n",W25Q_SPI_DEVICE_NAME);
    }
    else
    {
        rt_spi_configure(spi_w25q, &cfg);
        struct rt_spi_message msg1;
        
        msg1.send_buf   = &w25x_read_id;
        msg1.recv_buf   = &id;
        msg1.length     = 48;
        msg1.cs_take    = 1;
        msg1.cs_release = 0;
        msg1.next       = RT_NULL;
        rt_spi_transfer_message(spi_w25q, &msg1);
        
        rt_kprintf("use rt_spi_transfer_message() read w25q ID is:%x %x%x\n", id[1], id[2], id[3]);
    }
}
		
MSH_CMD_EXPORT(spi_w25q_sample, spi w25q sample);
```


至此，驱动代码编写完成。本代码还有很大的改进空间，未来会做源码上的改动，但无论如何改成什么样子，基本框架是不变的，读者完全可以参考本文编写spi甚至其他的驱动。另一方面，我们也可以看到RT-Thread驱动编写形式与Linux非常相似，这也是RT-Thread深受Linux启发的证明，读者也可以参考Linux来学习RT-Thread



