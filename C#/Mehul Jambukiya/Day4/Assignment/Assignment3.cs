﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class DateException : Exception
    {
        public DateException()
        {
            Console.WriteLine("Cannot enter date less than current date!!");
        }
    }
    class Assignment3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date(DD/MM/YYYY):");
            DateTime inpdate = DateTime.Parse(Console.ReadLine());
            try
            {
                if (inpdate < DateTime.Now.Date)
                {
                    throw new DateException();
                }
                else
                {
                    Console.WriteLine("Ok");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }
    }
}
