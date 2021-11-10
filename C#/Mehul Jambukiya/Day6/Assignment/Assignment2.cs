//Compute add of two number using lambda expression

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Assignment2
    {
        public delegate int Add(int a, int b);
        static void Main(string[] args)
        {
            Add addition = (a,b) => { return a+b; } ;
            int result = addition(5, 6);
            Console.WriteLine($"Addition result is : {result}");
            Console.ReadKey();
        }
    }
}
