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
| Creation | Designed by Sun Microsystems. | 3 |
| Ecosystem | Has a huge opensource ecosystem. | Used to develop software for Microsoft platforms. |
| Support for generics | It is implemented using erasures and casts added upon compilation into bytecode. | Integrated into the CLI and allows type information to be available at runtime |
