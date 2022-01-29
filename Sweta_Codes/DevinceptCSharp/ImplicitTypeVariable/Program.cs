using System;

namespace ImplicitTypeVariable
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = 29.99M;
			var b = 99L;
			var c = "Hello World!";

			Console.WriteLine("Type of {0} is : {1}", a, a.GetType());
			Console.WriteLine("Type of {0} is : {1}", b, b.GetType());
			Console.WriteLine("Type of {0} is : {1}", c, c.GetType());
		}
	}
}
