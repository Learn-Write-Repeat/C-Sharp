# Introduction to C#
---
## `What is C#?`

C# is a general-purpose, modern and object-oriented programming [(OOPs)](https://www.geeksforgeeks.org/introduction-of-object-oriented-programming/) language pronounced as “C sharp”. It was developed by Microsoft led by Anders Hejlsberg and his team within the .Net initiative and was approved by the European Computer Manufacturers Association (ECMA) and International Standards Organization (ISO). It runs in [.NET framework](https://www.geeksforgeeks.org/introduction-to-net-framework/).

## `C# vs JAVA`

- Java runs on the Java Runtime Environment [(JRE)](https://www.ibm.com/in-en/cloud/learn/jre) whereas C# is designed to be run on the Common Language Runtime [(CLR)](https://www.geeksforgeeks.org/common-language-runtime-clr-in-c-sharp/).

<img src="https://user-images.githubusercontent.com/70569920/127671643-3d236157-603d-4d45-8e44-4d70816fb4a8.jpg" width="600" height="500" />  <img src="https://user-images.githubusercontent.com/70569920/127671706-56f6a276-40df-472e-91f0-cdf0764bc6cf.jpg" width="600" height="500" />

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


| Parameters | Java | c# |
|------------|------|----|
| Creation| Designed by Sun Microsystems.| Designed as part of Microsoft's .NET initiative.|
| Ecosystem| Has a huge opensource ecosystem.| Used to develop software for Microsoft platforms.|
| Support for generics | It is implemented using erasures and casts added upon compilation into bytecode. | Integrated into the CLI and allows type information to be available at runtime|
| Support for delegates | Requires use of an interface to achieve similar functionality. | Has delegates which serve as methods that can be called without knowledge of target object.|
|Checked exceptions|Only has one type of exception|Distinguishes between checked and unchecked exceptions|
|Polymorphism|Invokes the "virtual" keyword in a base class and "override" keyword in a derived class.|Enables polymorphism by default.|
|Designed for|Java programming language is intended to be run on a Java platform, by the help of Java Runtime Environment (JRE).|The C# programming language is designed to be run on the Common Language Runtime (CLR).|
|Safety type|Java type safety is safe.|C# type of safety is unsafe.|
|Built-in Datatype|Built-in data types that are passed by value are called simple types.|Built-in data types that are passed by value are known as primitive types.|
|Arrays|Arrays in Java are a direct specialization of Object.|Arrays in C# are a specialization of System.|
|Support for conditional compilation.|Java doesn't provide support for conditional compilation|C# supports conditional compilation feature with the help of preprocessor directives.|
|Support for Goto statement.|Java doesn't support the goto statement.|C# supports the goto statement.|
|Structure and unions|Java doesn't support structures and unions.|C# supports structures and unions.|
|Operator Overloading|No support for operator overloading|C# provides support for operator overloading for multiple operators.|
|Number of Public Classes|In Java, there is an only a single public class inside source code, or it will display compilation error.|In C#, there are multiple public classes included in the source code.|
|Control for API|It is controlled by an open community process.|Microsoft controls C# API.|
|Runtime Environment|Java supports JVM(Java Virtual Machine).|C# supports CLR(Common Language Runtime).|
|Platform Dependency|Java is a robust and platform independent language.|Code written in C# is windows specific.|
		
				
		