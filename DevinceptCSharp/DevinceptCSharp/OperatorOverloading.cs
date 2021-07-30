using System;
using System.Collections.Generic;
using System.Text;

namespace DevinceptCSharp
{
	class OperatorOverloading
	{
		int feet, inch;
		public OperatorOverloading()
		{
			this.feet = 0;
			this.inch = 0;
		}

		public OperatorOverloading(int feet, int inch)
		{
			this.feet = feet;
			this.inch = inch;
		}

		public static OperatorOverloading operator +(OperatorOverloading l1, OperatorOverloading l2)
		{
			OperatorOverloading l3 = new OperatorOverloading();
			l3.feet = l1.feet + l2.feet;
			l3.inch = l1.inch + l2.inch;
			if (l3.inch >= 12)
			{
				l3.feet++;
				l3.inch -= 12;
			}
			return l3;
		}
		string GetLength()
		{
			return String.Format("Length : {0}' {1}\"", feet, inch);
		}

		static void Main(string[] args)
		{
			OperatorOverloading len1 = new OperatorOverloading(2, 8);
			OperatorOverloading len2 = new OperatorOverloading(4, 5);
			OperatorOverloading len3 = len1 + len2;

			Console.WriteLine(len1.GetLength());
			Console.WriteLine(len2.GetLength());
		}
	}
}
