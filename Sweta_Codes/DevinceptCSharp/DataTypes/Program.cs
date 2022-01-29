using System;

namespace DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			sbyte a = 2;
			byte b = 22;
			long c = 39999L;
			string st = "Hi Visitor";
			bool z = true;

			if (z)
			{
				Console.WriteLine(st);
			}

			Console.WriteLine("a with value {0} type {1}", a, a.GetType());
			Console.WriteLine("b with value {0} type {1}", b, b.GetType());
			Console.WriteLine("c with value {0} type {1}", c, c.GetType());
			Console.WriteLine("st with value {0} type {1}", st, st.GetType());
			Console.WriteLine("z with value {0} type {1}", z, z.GetType());
		}
	}
}
