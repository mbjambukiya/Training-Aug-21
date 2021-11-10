using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_8
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Practice
    {
        static void Main(string[] args)
        {
            //var primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19 };
            //var query = from val in primes where val < 13 select val;
            //foreach(var val in query)
            //{
            //    Console.WriteLine(val);
            //}
            //var methodQuery = primes.Where(x => x < 13);
            //foreach (var val in methodQuery)
            //{
            //    Console.WriteLine(val);
            //}

            //var names = new List<string> { "aaa", "ccc", "ddd", "bbb","aaa","ddd" };

            //var query = from name in names 
            //            orderby name 
            //            group name by name into groups 
            //            select new { Name = groups.Key, Count = groups.Count() } ;

            //foreach (var name in query)
            //{
            //    Console.WriteLine(name);
            //}

            //var list1 = Enumerable.Empty<int>();
            //var list2 = Enumerable.Range(1, 20);

            //bool list1empty = list1.Any();
            //bool list2empty = list2.Any();

            //Console.WriteLine("list1 empty?"+list1empty);
            //Console.WriteLine("list2 empty?"+list2empty);

            //Console.WriteLine("list2 contains 12?"+list2.Contains(12));
            //Console.WriteLine("list2 contains 30?"+list2.Contains(30));

            //var list3 = list2.Take(5).Select(x => x * 10);
            //foreach (var i in list3)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] code = { "IND", "AUS", "US" };
            //string[] country = {"India","Australia","United States" };

            //var countryWithCode = code.Zip(country,(ccode,cname)=>ccode+":"+cname);

            //foreach (var i in countryWithCode)
            //{
            //    Console.WriteLine(i);
            //}


            //operators

            //where

            //List<int> l = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            //var query = from num in l
            //            where (num % 2 == 0)
            //            select num;

            //foreach(var i in query)
            //{
            //    Console.WriteLine(i);
            //}

            //var mquery = l.Where((num) => num % 2 == 0);
            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i);
            //}

            //var mquery1 = l.Where((num) => num % 2 == 0).Where((num) => num >5);
            //foreach (var i in mquery1)
            //{
            //    Console.WriteLine(i);
            //}

            //OfType

            //ArrayList arr = new ArrayList() { 1, 2, 3, "aaa", "bbb" };
            //var query1 = from i in arr.OfType<int>() select i;
            //var query2 = from i in arr.OfType<string>() select i;
            //foreach (var i in query1)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (var i in query2)
            //{
            //    Console.WriteLine(i);
            //}
            //var mquery = arr.OfType<int>();
            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i);
            //}

            //orderby

            //List<int> l = new List<int>() { 17,15,11,1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var query = from num in l
            //            orderby num
            //            select num;

            //foreach (var i in query)
            //{
            //    Console.WriteLine(i);
            //}

            //var query1 = from num in l
            //            orderby num descending
            //            select num;

            //foreach (var i in query1)
            //{
            //    Console.WriteLine(i);
            //}

            //var mquery = l.OrderBy((num) => num );
            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i);
            //}
            //var mquery1 = l.OrderByDescending((num) => num);
            //foreach (var i in mquery1)
            //{
            //    Console.WriteLine(i);
            //}

            //groupby

            //List<int> l = new List<int>() { 1, 6, 17, 15, 11, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var query = from num in l
            //            group num by num;

            //foreach (var i in query)
            //{
            //    Console.WriteLine(i.Key+"-"+i.Count());
            //}
            //var mquery = l.GroupBy((num) => num);
            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i.Key + "-" + i.Count());
            //}

            //tolookup

            //List<int> l = new List<int>() { 1, 6, 17, 15, 11, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var mquery = l.ToLookup((num) => num);
            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i.Key + "-" + i.Count());
            //}

            //join

            //List<int> l1 = new List<int>() { 1, 2, 2, 3, 4,4, 5 };
            //List<int> l2 = new List<int>() { 4, 5, 6, 7, 8, 9 };
            //var mquery = l1.Join(l2, x => x, y => y, (x, y) => x);
            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i);
            //}

            //groupjoin

            //List<int> l1 = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };
            //List<int> l2 = new List<int>() { 4, 5, 6, 7, 8, 9 };
            //var mquery = l1.GroupJoin(l2, x => x, y => y, (x, y) => new {num = y });
            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i);
            //}

            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

            //select

            //var mquery = studentList.Select(i => new { name = i.StudentName, id = i.StudentID});

            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i.id+":"+i.name);
            //}

            //all&any

            //bool mquery1 = studentList.All(i => i.Age > 18);
            //Console.WriteLine(mquery1);
            //bool mquery2 = studentList.Any(i => i.Age > 18);
            //Console.WriteLine(mquery2);

            //contains

            //List<int> l1 = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };
            //var mquery = l1.Contains(2);
            //Console.WriteLine(mquery);

            //aggregate

            //List<string> l1 = new List<string>() { "aaa","bbb","ccc","ddd","eee" };
            //var mquery = l1.Aggregate("Aggregated List : ",(s1, s2) => s1 += s2 + ",");
            //Console.WriteLine(mquery);

            //average

            //List<int> l1 = new List<int>() { 10,20,30,40,50 };
            //var mquery = l1.Average((num)=>num);
            //Console.WriteLine(mquery);

            //count

            //List<int> l1 = new List<int>() { 10, 20,25,30, 41, 50};
            //var mquery = l1.Count(num => num % 2 == 0);
            //Console.WriteLine(mquery);

            //max & min

            //List<int> l1 = new List<int>() { 10, 20, 25, 30, 41, 50 ,57};
            //var mquery = l1.Max();
            //var mquery = l1.Max(num => { 
            //                                if (num % 2 == 0) 
            //                                    return num; 
            //                                else return 0; 
            //                            });
            //Console.WriteLine(mquery);

            //List<int> l1 = new List<int>() { 5,10, 20, 25, 30, 41, 50, 57 };
            //var mquery = l1.Min();
            //Console.WriteLine(mquery);

            //sum

            //List<int> l1 = new List<int>() { 5, 10, 20, 25, 30, 41, 50, 67 };
            //var mquery = l1.Sum();
            //Console.WriteLine(mquery);

            //single & singleordefault

            //List<int> l1 = new List<int>() {};
            //List<int> l2 = new List<int>() {5};
            //List<int> l3 = new List<int>() {5,10};
            ////Console.WriteLine("only one element? " + l1.Single());
            //Console.WriteLine("only one element? " + l1.SingleOrDefault());
            //Console.WriteLine("only one element? " + l2.Single());
            //Console.WriteLine("only one element? " + l2.SingleOrDefault());
            ////Console.WriteLine("only one element? " + l3.Single());
            ////Console.WriteLine("only one element? " + l3.SingleOrDefault());

            //defaultifempty

            //List<int> l = new List<int>() { };

            //var l1 = l.DefaultIfEmpty();
            //var l2 = l.DefaultIfEmpty(5);

            //Console.WriteLine("Count : "+l1.Count());
            //Console.WriteLine("Value : "+l1.ElementAt(0));
            //Console.WriteLine("Count : " + l2.Count());
            //Console.WriteLine("Value : " + l2.ElementAt(0));

            //intersect&union

            //List<int> l1 = new List<int>() { 1, 2, 2, 3, 4, 4, 5 };
            //List<int> l2 = new List<int>() { 4, 5, 6, 7, 8, 9 };

            //var mquery1 = l1.Intersect(l2);
            //foreach (var i in mquery1)
            //{
            //    Console.WriteLine(i);
            //}
            //var mquery2 = l1.Union(l2);

            //foreach (var i in mquery2)
            //{
            //    Console.WriteLine(i);
            //}

            //take&takewhile

            //List<int> l = new List<int>() { 1, 6, 17, 15, 11, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var mquery1 = l.Take(5);
            //foreach (var i in mquery1)
            //{
            //    Console.WriteLine(i);
            //}

            //var mquery2 = l.TakeWhile(num=>num<10);

            //foreach (var i in mquery2)
            //{
            //    Console.WriteLine(i);
            //}

            //defered execution

            //List<int> l = new List<int>() { 1, 6, 17, 15, 11, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var mquery = l.Select(i=>i);

            //foreach(var i in mquery)
            //{
            //    Console.WriteLine(i);
            //}

            //l.Add(99);

            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i);
            //}

            //immediate execution

            //List<int> l = new List<int>() { 1, 6, 17, 15, 11, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var mquery = l.Select(i => i).ToList();

            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i);
            //}

            //l.Add(99);

            //foreach (var i in mquery)
            //{
            //    Console.WriteLine(i);
            //}

            //let keyword

            //var query = from i in studentList
            //let lname = i.StudentName.ToLower()
            //where lname.StartsWith("r") || lname.StartsWith("j")
            //select lname;

            //foreach (var i in query)
            //{
            //    Console.WriteLine(i);
            //}

            //into keyword

            //var query = from i in studentList
            //            where i.Age > 18
            //            select i 
            //                into s
            //                where s.StudentName.StartsWith("R")
            //                select s;

            //foreach (var i in query)
            //{
            //    Console.WriteLine(i.StudentID + "," + i.StudentName + "," + i.Age);
            //}

            Console.ReadKey();
        }
    }
}
