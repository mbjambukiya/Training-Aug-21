//1.Print sum of all the even numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Assignment1
    {
        static void Main(string[] args)
        {
			int sum = 0;
			Console.WriteLine("Enter number");
			int num = Convert.ToInt32(Console.ReadLine());
			for(int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
					sum += i;
                }
			}
			Console.WriteLine($"sum of all even number from 0 to {num} is :" + sum);
            Console.ReadKey();
        }
    }
}
