# Python

# Python

## Python基础  

### 解释器与编译器  

解释器输出运行的结果
编译器输出编译的文件

字面量：写在代码中的值，可以被分为整数，浮点数，字符串，元组，列表等
python的单引号和双引号意义相同，但是使用单引号可以打出双引号，但不能打出单引号。使用双引号则反之，如果想使用单引号打出单引号，则需要加上反斜杠代表转义字符
  
<!-- more -->

### 注释的写法  

```py
# 这是单行注释

""" 
这是多
行注释 
""" 
```
python中变量无类型而数据有类型，可以通过type(数据)来查看数据拥有的数据类型，同时也可以使用type(变量)来查看变量拥有的数据类型  

### 类型转换  

```py
int(x) # 将x转换为int类型
float(x) # 将x转换为float类型
```

float转换为int会丢失精度
python舍弃精度时是**四舍五入**

### 运算符  

```py
print(9//4) # 结果为2
print(9%4)  # 结果为1
# ** 代表取幂运算
```

字符串可以通过转义字符来包含引号  

### 拼接  

```py
# 可以进行字符串之间的拼接，也可以进行字面量和变量之间的拼接
name = lzx
printf("The computer belong to " + lzx + "since 2023.")
# 但是不能将整数或其它类型与字符串拼接，例如
tel = 155
printf("The computer belong to " + lzx + "since 2023." + "tel is" + tel) #运行报错，提示int类型不能与str类型进行拼接，想要拼接首先要进行格式化
```

### 占位符与格式化  

```py
birth = 2001
name = "lzx"
message = "我是：%s，出生于：%d" %(name,birth)

# 或者

message = f"我是：{name}，出生于：{birth}" 
# 但是这种用法不能对精度进行控制，也不会考虑数据类型
```



### 输入函数  

```py
input("提示语") # input得到的数据永远是字符串类型
```  

### 条件语句  

python用4个空格来划分所属关系

```py
if condition:
    # todo
elif condition:
    # todo
else:
    # todo
```

### 循环语句

```py
while condition:
    # todo
    
for 临时变量 in 数据集 # for循环无法定义循环条件
    #todo
```

:::alert-info
for循环里的临时变量会自动自增，但是while需要手动自增
:::


### range  

```py
range(num) # 获得一个从0开始不含num的数字序列，例如range(5)，获得一个0，1，2，3，4的序列
range(num1,num2,step) #获得一个从num1开始，到num结束，步进为step的不含num2的数字序列

#range常用来配合for循环使用
for x in range(10)
```

### 函数  

```py
def functionname(parameter)
    # function body
    return returnvalue 

temp = 0

def fun1()
    global temp # 声明全局变量
    temp = 100
    return None
```

函数无返回值，返回的是None
对于一些不想要设置初始值而需要定义的变量来说，可以先让这个变量赋值为None

函数作为参数传递

```py
def fun1(fun):
    print("fun1")
    fun()
    print("fun1")


def fun2():
    print("fun2")


fun1(fun2) # 注意这里fun2不带()
```

### 数据容器  

![2024-01-20_13-37](/vx_images/445473713240161.png)

![2024-01-20_13-38](/vx_images/357703813258587.png)
  

#### 数据容器的转换

其他数据容器不能转换为字典

```py
# 将其他数据容器转换为列表
list(tuple_name()) # 字符串转列表会将字符串变为字符再装载进列表，字典转列表只会将Key值放进列表

# 将其他数据容器转换为元组
tuple(dict_name) # 情况与字符串列表类似

# 将其他数据容器转换为字符串
str(list_name) # 其他数据类型任意转换为字符串

# 将其他数据容器转换为集合
set(str_name) # 情况与字符串列表类似
```

#### 列表(list)  

![2024-01-19_21-28](/vx_images/392002821240160.png)

列表可以存储不同数据类型的元素，并按照一定下标排序，允许重复数据存在

```py
# 列表的字面量定义
[Item1,Item2,Item3] 

# 列表内的元素带有下标，可以通过下标索引到元素，索引方向分为从左至右和从右至左两种，下方列表中Item3的下标可以是2，也可以是-1
# 列表的变量定义
list_name = [Item1,Item2,Item3]

#定义空列表
list_name = []
list_name = list()
```
嵌套列表获取元素list_name[0][1]

将函数定义为类中的成员，我们称这种函数叫做方法

```py
#查询元素
list_name.index(Item1) # 查询Item1的下标，如果找不到则报错ValueError

#插入元素
list_name.insert(index，Item2) # 在index处插入Item2

#追加元素
list_name.append(Item3) # 在列表尾部追加append

#追加数据容器
list_name.extend(其他数据容器) #在列表尾部追加extend

#删除元素
element = list_name.pop(index) # 取出index的那个元素并赋值给element，最后在列表中删除

#清空整个列表
list_name.clear()

#统计某个元素在列表中的数量
list_name.count(Item4) 

#统计列表中有多少元素
len(list_name) # 返回值为列表中元素的个数
```
#### 元组(tuple)  

元组一旦定义好，内部的元素就不可修改。但如果元组内嵌套了list，则可以修改list的内容，可以将元组视为不可修改元素的list
元组内部数据类型可以不同

```py
# 定义元组字面量
(Item1，Item2，Item3)

# 定义元组变量
tuple_name = (Item1，Item2，Item3)

# 定义空元组
tuple_name = tuple()

```

#### 字符串(str)  

字符串是一个**不可修改**的数据容器

```py
my_str = "hellow world"

# 字符串的替换
new_str1 = my_str.replace("hellow","hello") # 原字符串不可修改，但得到了一个新的字符串

#字符串的分割
new_str2 = my_str.split(" ") # 按空格切分字符串，返回一个含有字符串的列表

```

#### 序列  

序列是指内容连续，有序，可使用下标索引的一类数据容器  

```py
# 语法
数据容器[start:end:step] # 在数据容器中从start下标开始到end下标结束(不包括end下标)，每隔step-1个元素取出一个数据组成新的序列，步长为负数则代表序列从后向前取

newlist = list_name[::2]

```

#### 集合(set)  

集合内元素不能重复且无序，但允许修改
因为集合不支持下标索引，所以不支持while循环，但支持for循环

```py
# 定义集合字面量
{Item1，Item2，Item3}

# 定义集合变量
set_name = {Item1，Item2，Item3}

# 定义空集合
set_name = set()

# 添加元素
set_name.add("Item4")

# 移除元素
set_name.remove("Item5")

# 清空集合
set_name.clear()

# 随机取元素
set_name.pop("Item6")

# 取出集合1不同于集合2的元素
set1 = {1,2,3}
set2 = {1,5,6}
set3 = set1.difference(set2)

# 更新集合1与集合2不同的元素
set1.difference_update(set2) # 结果set1 = {2,3}，set2不变

# 集合的合并
set3 = set1.union(set2)

```

#### 字典(dict)  

字典无序没有索引，只能通过Key值找到对应的value
字典的Key不可重复
字典的Key和value可以为任意数据类型(但Key不可为字典)

```py
# 字典的定义
dict_name = {Key:value,Key:value,Key:value}

# 空字典的定义
dict_name = dict()

# 找到Key对应的value
keyvalue = dict[Key]

# 添加或更新元素
dict_name[Key] = value # 有对应的key则更新元素，否则添加新的key及其对应元素

# 删除元素
Item = dict_name.pop(Key)

# 清空元素
dict_name.clear()

# 获取全部的Key 
AllKeys = dict_name.keys()
# 找到全部Key后遍历字典
for key in AllKeys
    # todo
# 或者直接遍历
for key in dict_name:
    # todo

```

### 函数进阶
#### 多返回值函数  

```py
def fun_name():
    return 1,2
    
x,y = fun_name()
```

* 函数参数种类：
    * 位置参数 fun_name("小明",10,"男")
    * 关键字参数 fun_name(name = "小明",gender = "男",age = 10)，顺序可以调换，但与位置参数混用时，需要放在位置参数后面
    * 缺省参数 函数定义时在参数列表中给参数赋值即可指定缺省参数，设置缺省参数时，设置的参数要放在参数列表最后，否则会报错
    * 不定长参数  
        * 位置参数的形式：fun_name(*args)，传参示例：`10，20，30`会将传进去的参数合并成一个元组
        * 关键字传递的形式：fun_name(**kwargs)，传参示例：`age = 10，gender = male`会将传进去的参数合并成一个字典 kwargs(key word args)
    
#### lambda函数  

lambda函数是一种临时函数，使用一次后就被销毁了，下次使用只能再次重写lambda函数并且lambda函数只能写一行

lambda函数语法：lambda 参数 : 函数体

```py
def test_fun(compete):
    result = compete(1,2)
    return result
    
def compete(x,y):
    return x + y
    
test_fun(compete)

#############与下列lambda函数相同#################
def test_fun(compete):
    result = compete(1,2)
    return result
    
test_fun(lambda x, y: x + y)
 
```

### 异常  

#### 异常的捕获
  
```py
try：
    可能发生异常的代码
    
except：
    处理异常的代码
    
#######################例子如下#########################

# 捕获到读取文件异常后(即文件不存在)，就以写的方式创建文件
try:
    f = open("linux.txt",'r')
    
execept: # execept可以后加异常名称，这样就会接受指定异常，例如 execept (NameError，ZeroDivisionError) as object:，默认情况则捕获所有异常并命名为 object，或者可以写为execept Exeception:，这也是捕获所有异常的写法
    f = open("linux.txt",'w')
    
else: # 没有异常则执行的代码
    # todo
finally: #无论是否出现异常都执行的代码
    # todo
```

#### 异常的传递  

异常可以根据函数调用呈现传递性  

![2024-01-20_16-31](/vx_images/368333116246454.png)  

### 模块  

模块就是一个python文件，可以将模块视作功能包
不同的模块，相同名称的功能，后导入进来的会覆盖先导入进来的
[]代表可选的意思

```py
# 只使用import会将模块中所有内容全部导入，而使用from则会将模块中的某一部分导入
# 例如 from time import sleep 使用方法：sleep 或者 import time 使用方法 time.sleep 
[from 模块名] import [模块 | 类 | 方法 | *] [as 别名]

```

### 包

python包 = \_\_init\_\_.py + 若干模块文件  

可以在 \_\_init\_\_.py文件内添加 \_\_all\_\_ = ["模块名"]来定义 from package import * 的导入范围

![2024-01-20_17-33](/vx_images/236873317266620.png)  


### 面向对象  

#### 类的定义  

```py
class 类名称:
    成员变量
    成员方法(函数)

# 定义类的方法时与普通的函数定义有细微差别，需要在形参列表最前方加入self关键字
# 在成员方法内部调用或赋值成员变量需要用到self.来引出
    def add(self,para1,para2):
    # todo    

# 创建类的对象
object = calss_name()
```

#### 构造方法  

构造方法需要使用__init\_\_()方法，与C++构造函数类似，即使不给出__init__()方法，系统也会自动调用

类进行初始化的时候会首先调用\_\_init\_\_()方法，，这个函数可以初始化类的成员变量

```py
class student:
    name = None
    age = None
    tel = None
    
    def __init__(self,name,age,tel)
        self.name = name
        self.age = age
        self.tel = tel    
     
```
#### 魔术方法  

python中，由两个下划线前后包围起来的方法称为魔术方法
定义__str__方法后，以后将类转换为字符串就会输出__str__方法中的内容
\_\_lt\_\_，\_\_le\_\_，\_\_eq\_\_是比较两个类大小的魔术方法，由于两个类不能比较，所以需要在这三种方法内部重写比较方法，一般比较的是两个类中成员的大小  

#### 封装  

在成员或者方法前加两个下划线即可将成员或方法变为私有  
```py
class student:
    name = None
    __age = 18 # 私有成员
    tel = None 
    def __print_tel(self): # 私有方法
        print(f"self.tel")
```

#### 继承

class 类名(父类名):
    类的内容
    
想要继承多个父类时使用：
class 类名(父类1,父类2,父类3):
    类的内容

如果只想继承若干个父类，而不想写类的内容，可以使用`pass`关键字，以补全类的内容
class 类名(父类1,父类2,父类3):
    pass

当父类1与父类2中有同名的成员变量或成员方法时，优先继承父类1的内容，遵循先来后到原则
```py
class student:
    name = None
    age = None
    tel = None
    
class Newstu(student): # 继承
    gender = None
```

当需要对父类的成员变量或者成员方法进行改动时，可以在子类中重新定义，以达到复写的效果
```py
class student:
    name = None
    age = 18
    tel = None
    
class Newstu(student): 
    age = 80
```

#### 多态  

多态：同一个函数，使用不同的对象，产生不同的结果

通过多子类父类以及继承方式可以实现多态，例如
* 定义空调父类，定义空调的制冷方法
* 定义格力空调，美的空调子类，并在其内部重写制冷方法
* 实现通用制冷函数，可以调用传进来的类的方法
* 在制冷函数内传入美的或者格力空调子类，这样就实现了多态现象

此时父类称为抽象类或接口，只做大体框架或者顶层实现

![2024-01-21_14-40](/vx_images/256514014258588.png)

### 闭包  

闭包的好处是可以将外层函数的变量置于函数内部，这样可以防止其他函数或操作修改外层函数的变量，使程序更安全。但同时内部函数会持续引用外部函数的值，增大了内存的开销

```py
def outer(add):
    def inner(name):
        print(f"<{add}>{name}<{add}>") # 如果想要修改add的值，只需要在add前加nonlocal关键字修饰即可

    return inner

fn1 = outer("海城") # 按正常的操作，需要定义一个海城的全局变量来传参，但是这样做全局变量有被其他函数修改的风险，使用了闭包后则不会修改这个变量
fn1("李政轩")
```
![2024-01-21_14-53](/vx_images/515795314246455.png =300x)

### 装饰器

装饰器是闭包的一种特殊用法，他将闭包中的全局变量改为函数，可以增加原函数的功能，并支持语法糖

```py
#############普通的装饰器##########
def outer(fun):
    def inner():
        print("海城")
        fun()
        print("李政轩")

    return inner


def fun1():
    print("四中")


fn = outer(fun1)
fn()


#############带语法糖的装饰器###########
def outer(fun):
    def inner():
        print("海城")
        fun()
        print("李政轩")

    return inner


@outer # 跟随outer函数名称改变而改变
def fun1():
    print("四中")


fun1() # 调用的是fun1，而不是outer，这样适合对原函数增加功能后继续调用

```

### 迭代器  

迭代是 Python 最强大的功能之一，是访问集合元素的一种方式。

迭代器是一个可以记住遍历的位置的对象。

迭代器对象从集合的第一个元素开始访问，直到所有的元素被访问完结束。迭代器只能往前不会后退。

```py
#!/usr/bin/python3
 
list_name=[1,2,3,4]
it = iter(list_name)    # 创建迭代器对象
for x in it:
    print (x, end=" ")
```
输出结果：
```py
1 2 3 4
```

把一个类作为一个迭代器使用需要在类中实现两个方法 \_\_iter\_\_() 与 \_\_next\_\_() 
\_\_iter\_\_() 方法返回一个特殊的迭代器对象， 这个迭代器对象实现了 \_\_next\_\_() 方法并通过 StopIteration 异常标识迭代的完成
\_\_next\_\_() 方法（Python 2 里是 next()）会返回下一个迭代器对象

```py
class MyNumbers:
  def __iter__(self):
    self.a = 1
    return self
 
  def __next__(self):
    x = self.a
    self.a += 1
    return x
 
myclass = MyNumbers()
myiter = iter(myclass)
 
print(next(myiter))
print(next(myiter))
print(next(myiter))
print(next(myiter))
print(next(myiter))
```
输出结果：
```py
1
2
3
4
5
```

### 生成器  

在 Python 中，使用了 yield 的函数被称为生成器（generator），生成器函数是一种特殊的函数，可以在迭代过程中逐步产生值，而不是一次性返回所有结果.跟普通函数不同的是，生成器是一个返回迭代器的函数，只能用于迭代操作，更简单点理解生成器就是一个迭代器

当在生成器函数中使用 yield 语句时，函数的执行将会暂停，并将 yield 后面的表达式作为当前迭代的值返回。然后，每次调用生成器的 next() 方法或使用 for 循环进行迭代时，函数会从上次暂停的地方继续执行，直到再次遇到 yield 语句。这样，生成器函数可以逐步产生值，而不需要一次性计算并返回所有结果。这样可以不必一次生成大量数据，从而节省内存空间

```py
def countdown(n):
    while n > 0:
        yield n
        n -= 1
 
# 创建生成器对象
generator = countdown(5)
 
# 通过迭代生成器获取值
print(next(generator))  # 输出: 5
print(next(generator))  # 输出: 4
print(next(generator))  # 输出: 3
 
# 使用 for 循环迭代生成器
for value in generator:
    print(value)  # 输出: 2 1
```

生成器实现fibonacci数列

```py
#!/usr/bin/python3
 
import sys
 
def fibonacci(n): # 生成器函数 - 斐波那契
    a, b, counter = 0, 1, 0
    while True:
        if (counter > n): 
            return
        yield a
        a, b = b, a + b
        counter += 1
f = fibonacci(10) # f 是一个迭代器，由生成器返回生成
 
while True:
    try:
        print (next(f), end=" ")
    except StopIteration:
        sys.exit()
```
输出结果：
```py
0 1 1 2 3 5 8 13 21 34 55
```

### 设计模式  


#### 单例模式  

类的实例化只进行一次，以后均使用这个实例化的类，这样可以节省内存，多用于工具类的创建

#### 工厂模式  

将杂散的对象由某个类统一创建，这样可以方便统一管理杂散的数据，并且当其中的数据进行重新赋值时，只进行类内部重新赋值即可而不需要找到每处实例化的对象


