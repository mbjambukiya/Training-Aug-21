using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day12_13.Models;
using Microsoft.EntityFrameworkCore;

namespace Day12_13
{
    class Practice
    {
        static void Main(string[] args)
        {
            //one to one

            //using (var context = new StuContext())
            //{
            //    var res = context.Grades.Include(x => x.StudentNavigation);
            //    var res1 = context.Students.Include(x => x.GradeNavigation);

            //    foreach (var item in res)
            //    {
            //        Console.WriteLine($"Student name : {item.StudentNavigation.Name}, Grade : {item.myGrade}");
            //    }
            //    foreach (var item in res1)
            //    {
            //        Console.WriteLine($"Student name : {item.Name}, Grade : {item.GradeNavigation.myGrade}");
            //    }

            //}

            //one to many

            //using (var context = new StuContext())
            //{
            //    var res = context.Grades.Include(x => x.StudentNavigation);
            //    var res1 = context.Students.Include(x => x.GradeNavigation);

            //    foreach (var item in res)
            //    {
            //        Console.WriteLine($"Student name : {item.StudentNavigation.Name}, Grade : {item.myGrade}");
            //    }
            //    foreach (var item in res1)
            //    {
            //        Console.WriteLine($"Student name : {item.Name}");
            //        foreach (var i in item.GradeNavigation)
            //        {
            //            Console.WriteLine(i.myGrade);
            //        }
            //    }
            //}
            Console.ReadKey();
        }
    }
}
