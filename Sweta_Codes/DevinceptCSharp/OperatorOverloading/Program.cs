using System;

namespace OperatorOverloading
{
	class Program
	{
		int feet, inch;
		public Program()
		{
			this.feet = 0;
			this.inch = 0;
		}

		public Program(int feet, int inch)
		{
			this.feet = feet;
			this.inch = inch;
		}

		public static Program operator +(Program l1, Program l2)
		{
			Program l3 = new Program();
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
			Program len1 = new Program(2, 8);
			Program len2 = new Program(4, 5);
			Program len3 = len1 + len2;

			Console.WriteLine(len1.GetLength());
			Console.WriteLine(len2.GetLength());
		}
	}
}
