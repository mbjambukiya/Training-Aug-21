//3.Create a weekday enum and accept week day number and display week day.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Assignment3
    {
		enum weekday { sunday = 1, monday, tuesday, wednesday, thursday, friday, saturday }
		static void Main(string[] args)
        {
			Console.WriteLine("Enter Weekday number(1st day is sunday):");
			int x = Convert.ToInt32(Console.ReadLine());
			switch (x)
			{
				case (int)weekday.sunday:
					Console.WriteLine("Sunday");
					break;
				case (int)weekday.monday:
					Console.WriteLine("Monday");
					break;
				case (int)weekday.tuesday:
					Console.WriteLine("Tuesday");
					break;
				case (int)weekday.wednesday:
					Console.WriteLine("Wednesday");
					break;
				case (int)weekday.thursday:
					Console.WriteLine("Thursday");
					break;
				case (int)weekday.friday:
					Console.WriteLine("Friday");
					break;
				case (int)weekday.saturday:
					Console.WriteLine("Saturday");
					break;
			}
		}

}
}
