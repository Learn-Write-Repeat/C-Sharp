# Introduction to C#
---
## `What is C#?`

C# is a general-purpose, modern and object-oriented programming [(OOPs)](https://www.geeksforgeeks.org/introduction-of-object-oriented-programming/) language pronounced as “C sharp”. It was developed by Microsoft led by Anders Hejlsberg and his team within the .Net initiative and was approved by the European Computer Manufacturers Association (ECMA) and International Standards Organization (ISO). It runs in [.NET framework](https://www.geeksforgeeks.org/introduction-to-net-framework/).

## `C# vs JAVA`

- Java runs on the Java Runtime Environment [(JRE)](https://www.ibm.com/in-en/cloud/learn/jre) whereas C# is designed to be run on the Common Language Runtime [(CLR)](https://www.geeksforgeeks.org/common-language-runtime-clr-in-c-sharp/).
<!-- <img src="https://user-images.githubusercontent.com/70569920/127671643-3d236157-603d-4d45-8e44-4d70816fb4a8.jpg" width="600" height="500" />  <img src="https://user-images.githubusercontent.com/70569920/127671706-56f6a276-40df-472e-91f0-cdf0764bc6cf.jpg" width="600" height="500" /> -->

- Java is a class-based Object Oriented language whereas C# is Object-Oriented, functional, strong typing, component-oriented.

- Java doesn’t support for [operator overloading](https://en.wikipedia.org/wiki/Operator_overloading) whereas C# provides [operator overloading](https://en.wikipedia.org/wiki/Operator_overloading) for multiple operators.

``` 
public static OperatorOverloading operator +(OperatorOverloading a, OperatorOverloading b)
{
	OperatorOverloading c = new OperatorOverloading();
	c.x = a.x + b.x;
	c.y = a.y + b.y;
        c.z = a.z + b.z;
	return c;
}

```
- Java does not support pointers while C# supports pointer only in an unsafe mode.
- In Java, Arrays are a direct specialization of Object whereas arrays in C# are a specialization of System.


| **_Parameters_** | **_Java_** | **_C#_** |
|------------|------|----|
| **Creation**| Designed by Sun Microsystems.| Designed as part of Microsoft's .NET initiative.|
| **Ecosystem**| Has a huge opensource ecosystem.| Used to develop software for Microsoft platforms.|
| **Support for generics** | It is implemented using erasures and casts added upon compilation into bytecode. | Integrated into the CLI and allows type information to be available at runtime|
| **Support for delegates** | Requires use of an interface to achieve similar functionality. | Has delegates which serve as methods that can be called without knowledge of target object.|
|**Checked exceptions**|Only has one type of exception|Distinguishes between checked and unchecked exceptions|
|**Polymorphism**|Invokes the "virtual" keyword in a base class and "override" keyword in a derived class.|Enables polymorphism by default.|
|**Designed for**|Java programming language is intended to be run on a Java platform, by the help of Java Runtime Environment (JRE).|The C# programming language is designed to be run on the Common Language Runtime (CLR).|
|**Safety type**|Java type safety is safe.|C# type of safety is unsafe.|
|**Built-in Datatype**|Built-in data types that are passed by value are called simple types.|Built-in data types that are passed by value are known as primitive types.|
|**Arrays**|Arrays in Java are a direct specialization of Object.|Arrays in C# are a specialization of System.|
|**Support for conditional compilation**|Java doesn't provide support for conditional compilation|C# supports conditional compilation feature with the help of preprocessor directives.|
|**Support for Goto statement**|Java doesn't support the goto statement.|C# supports the goto statement.|
|**Structure and unions**|Java doesn't support structures and unions.|C# supports structures and unions.|
|**Operator Overloading**|No support for operator overloading|C# provides support for operator overloading for multiple operators.|
|**Number of Public Classes**|In Java, there is an only a single public class inside source code, or it will display compilation error.|In C#, there are multiple public classes included in the source code.|
|**Pointers**|Java does not support pointers.|In C# you can use pointer only in an unsafe mode.|
|**Control for API**|It is controlled by an open community process.|Microsoft controls C# API.|
|**Runtime Environment**|Java supports JVM(Java Virtual Machine).|C# supports CLR(Common Language Runtime).|
|**Platform Dependency**|Java is a robust and platform independent language.|Code written in C# is windows specific.|
|**IDE**|Eclipse, NetBeans, IntelliJ IDEA|Visual Studio, MonoDevelop|
		

## `History of C#`

The C# language relies on types and methods in what the C# specification defines as a standard library for some of the features. The .NET platform delivers those types and methods in a number of packages.

1.  [C# version 1.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-10)
2.  [C# version 1.2](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-12)
3.  [C# version 2.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-20)
4.  [C# version 3.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-30)
5.  [C# version 4.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-40)
6.  [C# version 5.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-50)
7.  [C# version 6.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-60)
8.  [C# version 7.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-70)
9.  [C# version 7.1](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-71)
10. [C# version 7.2](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-72)
11. [C# version 7.3](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-73)
12. [C# version 8.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-80)
13. [C# version 9.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-90)

## `Features of C#`

C# is object oriented programming language. It provides a lot of features that are given below.

1. Simple
2. Modern programming language
3. Object oriented
4. Type safe
5. Interoperability
6. Scalable and Updateable
7. Component oriented
8. Structured programming language
9. Rich Library
10. Fast speed

<img src="https://user-images.githubusercontent.com/70569920/127698419-73fd9f2b-837b-47e1-8061-e32590794732.png" width="450" height="450" />
<!-- ![C#_Features](https://user-images.githubusercontent.com/70569920/127698419-73fd9f2b-837b-47e1-8061-e32590794732.png) -->

## `Data Types in C#`

Data types specify the type of data that a valid C# variable can hold. C# is a strongly typed programming language because in C#, each type of data (such as integer, character, float, and so forth) is predefined as part of the programming language and all constants or variables defined for a given program must be described with one of the data types.

Data types in C# is mainly divided into three categories

- Value Data Types
- Reference Data Types
- Pointer Data Type

### 1. `Value Data Types`

 In C#, the Value Data Types will directly store the variable value in memory and it will also accept both signed and unsigned literals. The derived class for these data types are System.ValueType. Following are different Value Data Types in C# programming language :
- <ins>Signed & Unsigned Integral Types</ins>

| Alias | Type Name | Type | Size(bits) | Range | Default Value |
| --- | --- | --- | --- | --- | --- |
| sbyte | System.Sbyte | signed integer | 8 | -128 to 127 | 0 |
| short | System.Int16 | signed integer | 16 | -32768 to 32767 | 0 |
| Int | System.Int32 | signed integer | 32 | -231 to 231-1 | 0 |
| byte | System.byte | unsigned integer | 8 | 0 to 255 | 0 | 
| uint | System.UInt32 | unsigned integer | 32 | 0 to 232 | 0 |
| long | System.Int64 | signed integer | 64 | -263 to 263-1 | 0L |
| ushort | System.UInt16 | unsigned integer | 16 | 0 to 65535 | 0 | 
| ulong | System.UInt64 | unsigned integer | 64 | 0 to 263 | 0 |

- <ins>Floating Point Types</ins>

| Alias | Type name | Size(bits) | Range (aprox) | Default Value |
| --- | --- | --- | --- | --- |
| float | System.Single | 32 | ±1.5 × 10-45 to ±3.4 × 1038 | 0.0F |
| double | System.Double | 64 |	±5.0 × 10-324 to ±1.7 × 10308 | 0.0D |

- <ins>Decimal Types</ins>

| Alias | Type name | Size(bits) | Range (aprox) | Default value |
| --- | --- | --- | --- | --- |
| decimal | System.Decimal | 128 | ±1.0 × 10-28 to ±7.9228 × 1028 |	0.0M |

- <ins>Character Types</ins>

| Alias | Type name | Size In(Bits) | Range | Default value |
| --- | --- | --- | --- | --- |
| char | System.Char | 16 | U +0000 to U +ffff | ‘\0’ |

- <ins>Boolean Types</ins>

| Alias | Type name | Values |
| --- | --- | --- |
| bool | System.Boolean	| True / False |

### 2. `Reference Data Types`

The Reference Data Types will contain a memory address of variable value because the reference types won’t store the variable value directly in memory. The built-in reference types are `string`, `object`.

- <ins>String</ins>
 It represents a sequence of Unicode characters and its type name is System.String. So, string and String are equivalent.
 ```
	string s1 = "Hello"; // creating through string keyword  
	String s2 = "World!"; // creating through String class 
 ```

- <ins>Object</ins>
In C#, all types, predefined and user-defined, reference types and value types, inherit directly or indirectly from Object. So basically it is the base class for all the data types in C#. Before assigning values, it needs type conversion. When a variable of a value type is converted to object, it’s called boxing. When a variable of type object is converted to a value type, it’s called unboxing. Its type name is System.Object.

### 3. `Pointer Data Types`

The Pointer Data Types will contain a memory address of the variable value.To get the pointer details we have a two symbols ampersand (&) and asterisk (*).<br>
`ampersand (&)` : It is Known as Address Operator. It is used to determine the address of a variable.<br>
`asterisk (*)`  : It also known as Indirection Operator. It is used to access the value of an address.

**Syntax :**
```
type* identifier;
```


## `Variables in C#`

A Variable is basically a placeholder of the information which can be changed at runtime. And variables allows to Retrieve and Manipulate the stored information.

**Syntax:**
```
type variable_name = value; 
or
type variable_names;
```

**<ins>Rules for Naming Variables</ins>**

- Variable names can contain the letters ‘a-z’ or ’A-Z’ or digits 0-9 as well as the character ‘_’.
- The name of the variables cannot be started with a digit.
- The name of the variable cannot be any C# keyword say int, float, null, String, etc.

**<ins>Initializing Variables</ins>**

 In C# each data type has some default value which is used when there is no explicitly set value for a given variable. Initialization can be done separately or may be with declaration.

 **Example :**
 ```
int length = 20; // Declaring and initializing the variable at same time
int age; // Declaring variable age
age = 35; // initializing age with value 35
 ```

**Two Ways for Initialization:**

1. Compile time initialization : It means to provide the value to the variable during the compilation of the program.
2. Run time initialization :  In this, the user has to enter the value and that value is copied to the required variable.

**Note: Here the Console.ReadLine() method asks the user to enter the value and later on it puts the same value in the “num” variable. Hence the value will be displayed according to the user input.**

### `Implicitly Type Local Variable (var)`

Implicitly typed variables are those variables which are declared without specifying the .NET type explicitly. In implicitly typed variable, the type of the variable is automatically deduced at compile time by the compiler from the value used to initialize the variable. The implicitly typed variable concept is introduced in C# 3.0. The implicitly typed variable is not designed to replace the normal variable declaration, it is designed to handle some special-case situation like LINQ(Language-Integrated Query).

- `Why it is termed Local?`
Answer: It is not allowed to use var as a parameter value or return type in the method or defining it at class level etc. because the scope of the implicitly typed variable is local.


## `Operators in C#`

Operators are the foundation of any programming language. Thus the functionality of C# language is incomplete without the use of operators. Operators allow us to perform different kinds of operations on operands. In C#, operators Can be categorized based upon their different functionality :

1. Arithmetic Operators
2. Relational Operators
3. Logical Operators
4. Bitwise Operators
5. Assignment Operators
6. Conditional Operator

In C#, Operators can also categorized based upon Number of Operands : 

- **Unary Operator:** Operator that takes one operand to perform the operation.
- **Binary Operator:** Operator that takes two operands to perform the operation.
- **Ternary Operator:** Operator that takes three operands to perform the operation.

### 1. `Arithmetic Operators`

- Addition (+)
- Subtraction (-)
- Multiplication (*)
- Division (/)
- Modulus (%)

**Unary Operators**

- Increment Operator 
	- Pre-increment Operator (++a)
	- Post-increment Operator (a++)
- Decrement Operator 
	- Pre-decrement Operator (--a)
	- Post-decrement Operator (a--)

### 2. `Relational Operators`

Relational operators are used for comparison of two values.

- == (Equal To)
- != (Not Equal To)
- \> (Greater Than) 
- < (Less Than)
- \>= (Greater Than Equal To)
- <= (Less Than Equal To)

### 3. `Logical Operators`

They are used to combine two or more conditions/constraints or to complement the evaluation of the original condition in consideration. They are described below:

- Logical AND (&&)
- Logical OR (||)
- Logical NOT (!)

### 4. `Bitwise Operators`

In C#, there are 6 bitwise operators which work at bit level or used to perform bit by bit operations. Following are the bitwise operators :

- & (bitwise AND)
- | (bitwise OR)
- ^ (bitwise XOR)
- << (left shift)
- \>> (right shift)

### 5. `Assignment Operators`

Assignment operators are used to assigning a value to a variable. The left side operand of the assignment operator is a variable and right side operand of the assignment operator is a value. The value on the right side must be of the same data-type of the variable on the left side otherwise the compiler will raise an error.

- = (Simple Assignment)<br>
	Example:<br>
		```
		a = 10;
		```

- += (Add Assignment)<br>
	Example:<br>
		```
		a += b; // Equivalent to a = a + b
		```

- -= (Subtract Assignment)<br>
	Example:<br>
		```
		a -= b; // Equivalent to a = a - b
		```

- \*= (Multiply Assignment)<br>
	Example:<br>
		```
		a *= b; // Equivalent to a = a * b
		```
	
- /= (Division Assignment)<br>
	Example:<br>
		```
		a /= b; // Equivalent to a = a / b
		```

- %= (Modulus Assignment)<br>
	Example:<br>
		```
		a %= b; // Equivalent to a = a % b
		```

- <<= (Left Shift Assignment)<br>
	Example:<br>
		```
		a <<= 2; // Equivalent to a = a << 2
		```

- \>>= (Right Shift Assignment)<br>
	Example:<br>
		```
		a >>= 2; // Equivalent to a = a >> 2
		```

- &= (Bitwise AND Assignment)<br>
	Example:<br>
		```
		a &= 2; // Equivalent to a = a & 2
		```

- ^= (Bitwise Exclusive OR)<br>
	Example:<br>
		```
		a ^= 2; // Equivalent to a = a ^ 2
		```

- |= (Bitwise Inclusive OR)<br>
	Example :<br>
		```
		a |= 2; // Equivalent to a = a | 2
		```

### 6. `Conditional Operator`

It is ternary operator which is a shorthand version of if-else statement. It has three operands and hence the name ternary. It will return one of two values depending on the value of a Boolean expression. 

**Syntax:**
```
condition ? first_expression : second_expression;
```