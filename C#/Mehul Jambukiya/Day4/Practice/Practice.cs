using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("This is user defined exception!!");
        }
    }
    class Practice
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int i = 10;
            //    int res = i / 0;    
            //    Console.WriteLine(i);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block!!");
            //}

            //try
            //{
            //    if (true)
            //    {
            //        throw new MyException();
            //    }
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block!!");
            //}

            //StringBuilder name = new StringBuilder("John");
            //Console.WriteLine(name);

            //name.Append("Abc");
            //Console.WriteLine(name);

            //name.Insert(name.Length, "Inserted text");
            //Console.WriteLine(name);

            //name.Remove(7,name.Length-7);
            //Console.WriteLine(name);

            //name.Replace('A', 'a');
            //Console.WriteLine(name);

            //string str1 = "Hello";
            //string str2 = " World!";
            //string str3 = string.Concat(str1, str2);
            //Console.WriteLine(str3);

            //DateTime d1 = new DateTime();
            //Console.WriteLine(d1);
            //d1 = DateTime.Now;
            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Year);
            //Console.WriteLine(d1.Month);
            //Console.WriteLine(d1.Day);
            //Console.WriteLine(d1.Hour);
            //Console.WriteLine(d1.Minute);
            //Console.WriteLine(d1.Second);
            //Console.WriteLine(d1.Millisecond);

            //DateTime d2 = new DateTime(2021,12,01);
            //Console.WriteLine(d2);

            //Console.WriteLine(d2.AddDays(5));
            //Console.WriteLine(d2.AddMonths(5));

            //string date = "24/10/2021 10:40:25";
            //DateTime d3 = DateTime.Parse(date);
            //Console.WriteLine(d3);

            Console.ReadKey();
        }
    }
}
