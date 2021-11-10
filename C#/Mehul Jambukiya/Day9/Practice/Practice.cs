using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Practice
    {
        static void Main(string[] args)
        {
            method1();
            method2();
            method3();
            Console.ReadKey();
        }
        static void method1()
        {
            Console.WriteLine("Method1...");
        }
        static async Task method2()
        {
            await Task.Run(()=>{
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine("Method2...");
                }
            });
        }
        static void method3()
        {
            Console.WriteLine("Method3...");
        }

    }
}
