//2.Store your name in one string and find out how many vowel characters 
//are there in your name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Assignment2
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter your name");
			string name = Console.ReadLine();
			char[] vowelarr = { 'a', 'e', 'i', 'o', 'u' };
			int sum = 0;
			for (int i = 0; i < name.Length; i++)
			{
				Console.WriteLine(name[i]);
				if (vowelarr.Contains(name[i]))
				{
					sum += 1;
				}
			}
			Console.WriteLine(sum);
            Console.ReadKey();
        }
	}
}
