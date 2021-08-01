using System;

namespace DynamicType
{
	class Program
	{
		static void Main(string[] args)
		{
			dynamic am = "00:00";
			dynamic pm = "12:00";
			dynamic nowTime = DateTime.Now;

			Console.WriteLine("AM starts from {0} whose type is {1}", am, am.GetType());
			Console.WriteLine("PM starts from {0} whose type is {1}", pm, pm.GetType());
			Console.WriteLine("Current time is {0} whose type is {1}", nowTime, nowTime.GetType());
		}
	}
}
