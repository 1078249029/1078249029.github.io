# 杂记


# 2020s
## 2025年
### 4月

#### 7日

markdown测试

**粗体** *斜体*

* 无序1
* 无序2
    * 无序3  
    
$E=mc^2$

[链接测试-百度](www.baidu.com)

这是一个数字脚注[^1].
这是一个带标签的脚注[^label]

[^1]: 这是一个数字脚注
[^label]: 这是一个带标签的脚注

>引用
>>引用

---

测试回复

---

## 从C到C++

### 对象与实例  

* 什么是对象？
* 对象是类的具体化，类是对象的模板或蓝图。类定义了数据的结构（成员变量）和操作数据的方法（成员函数），但类本身并不占用内存 。对于那些重载函数操作运算符的类我们称为函数对象

* 什么是实例？
* 实例是对象的另一个名称。一个类可以有多个对象，每个对象都是该类的一个实例

### new和delete  

尽管C++11引入了智能指针，但是为了兼容老程序，new和delete的方法也应值得注意

* C原生的malloc与free使用起来较为复杂，需要根据返回值来判断下一步做什么
* C原生的malloc与free也只进行内存申请但不进行对象实例化，也就是说C仅仅返回内存地址的指针，而C++返回的是一块特定类型的指针
* 更重要的是C++在调用new时会自动执行对象的构造函数，C原生的malloc与free则不支持

在使用delete回收数组时需要告诉他数组的类型
```cpp
new int arr[10];
delete [] arr;
```

```cpp
//new和delete使用时需要加上数据类型

new int(10) //从堆区获取1个整型的空间，并赋值为10
int *p = new int[10] //从堆区获取10个整型的数组空间

delete [10] p //从堆区释放10个整型的数组空间
```

### 作用域运算符  

当在函数内需要访问全局变量时我们可以使用 ::全局变量 的方式访问，这一般在全局变量和局部变量名字冲突时使用

---

分割栏测试

---

测试
### 命名空间  

为了在大型项目中管理符号与名称，C语言采用了static关键字，而C++采用了命名空间，这样在调用多个厂商的类库时就不会重名了

```cpp
namespace A
{
    int a = 100;
}

namespace B
{
    int a = 200;
}

int main()
{
    cout << A::a << endl;
}
```


### using的使用

使用using关键字后就可以不需要指定哪个命名空间的作用域了
```cpp
namespace A
{
    int a = 100;
}

namespace B
{
    int a = 200;
}

int main()
{
using namespace A
    cout << a << endl;
}
```

using还用于类型别名的声明，我们终于可以不用忍受蹩脚的typedef了
```cpp
using func_t = void (int);
//或者这样
using func_t = void (*)(int);

template<class T>
using Vec = vector<T, Alloc<T>>; // 类型标识为 vector<T, Alloc<T>>
```

## 函数的别名

我们可以使用typedef与using来给函数起别名

```cpp
#include <iostream>
using func_t = void (int);    

void hello(func_t func3){    
    func3(6);
}

void func(int a){
    std::cout << a << std::endl;
}

int main() {
    hello(func);
    return 0;
}
```
实际上我们写成下面的形式也会过编译
```cpp
using func_t = void (int);    

void hello(func_t * func3){    
    func3(6);
}
//或者下面这样的
using func_t = void (*)(int);    

void hello(func_t func3){    
    func3(6);
}
//但就不能写成下面的的形式，这会报编译错误 error: cannot convert 'void (*)(int)' to 'void (**)(int)
using func_t = void (*)(int);    

void hello(func_t * func3){    
    func3(6);
}
```
typedef也同理
```cpp
//下面3个没问题
typedef  void(*func_t)(int);

void hello(func_t  func3){    
    func3(6);
}

typedef  void(func_t)(int);

void hello(func_t  func3){    
    func3(6);
}

typedef  void(func_t)(int);

void hello(func_t * func3){    
    func3(6);
}
//这就有问题了
typedef  void(*func_t)(int);

void hello(func_t * func3){    
    func3(6);
}
```


