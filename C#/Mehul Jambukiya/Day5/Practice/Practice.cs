using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Practice
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //al.Add("Hello");
            //al.Add(10);
            //al.Insert(1, "Everyone");
            //Console.WriteLine(al);
            //Console.WriteLine(al.Capacity);
            //Console.WriteLine(al.Count);
            //foreach (var i in al)
            //{
            //    Console.WriteLine(i);
            //}
            //for(int i = 0; i < al.Count; i++)
            //{
            //    Console.WriteLine(al[i]);
            //}
            //al.Remove(10);
            //foreach (var i in al)
            //{
            //    Console.WriteLine(i);
            //}
            //al.RemoveAt(0);
            //foreach (var i in al)
            //{
            //    Console.WriteLine(i);
            //}
            //al.Add(10);
            //al.Add(11);
            //al.Add(12);
            //al.Add(13);
            //al.RemoveRange(1, 3);
            //foreach (var i in al)
            //{
            //    Console.WriteLine(i);
            //}
            //al.Clear();
            //Console.WriteLine(al.Count);
            //Console.WriteLine(al.Capacity);

            //al.Add(12);
            //al.Add(11);
            //al.Add(13);
            ////al.Add("abc");
            //al.Add(10);

            //al.Sort();
            //foreach (var i in al)
            //{
            //    Console.WriteLine(i);
            //}

            //Hashtable ht = new Hashtable();
            //ht.Add(1, "abc");
            //ht.Add(2, "def");
            //ht.Add(3, "efg");
            //ht.Add(4, "xyz");
            //Console.WriteLine(ht[1]);
            //foreach (DictionaryEntry i in ht)
            //{
            //    Console.WriteLine(i.Key.ToString()+":"+i.Value);
            //}
            //ht.Remove(2);
            //foreach (DictionaryEntry i in ht)
            //{
            //    Console.WriteLine(i.Key.ToString() + ":" + i.Value);
            //}

            //SortedList sl = new SortedList();
            //SortedList sl2 = new SortedList();

            //sl.Add(1, "abc");
            //sl.Add(2, "def");
            ////sl.Add("a", "aaa");
            //sl.Add(3, "efg");
            //sl.Add(4, "xyz");
            //sl.Add(5, "xyz");
            //sl.Add(6, "xyz");
            //sl.Add(7, "xyz");
            //sl.Add(8, "xyz");
            //sl.Add(9, "xyz");
            //sl.Add(10, "xyz");
            //sl.Add(11, "xyz");
            //sl.Add(12, "xyz");
            //sl.Add(13, "xyz");
            //sl.Add(14, "xyz");
            //sl.Add(15, "xyz");
            //sl.Add(16, "xyz");
            //sl.Add(17, "xyz");

            //Console.WriteLine(sl.Capacity);
            //Console.WriteLine(sl.Count);

            //Console.WriteLine(sl.IndexOfKey(5));
            //Console.WriteLine(sl.IndexOfValue("abc"));
            //Console.WriteLine(sl.IndexOfValue("xyz"));


            //Console.WriteLine(sl.ContainsKey(5));
            //Console.WriteLine(sl.ContainsKey(50));
            //Console.WriteLine(sl.ContainsValue("abc"));
            //Console.WriteLine(sl.ContainsValue("aaa"));

            //sl2.Add("p", "pqr");
            //sl2.Add("x", "xyz");
            //sl2.Add("a", "abc");

            //sl.Clear();
            //sl2.Remove("a");

            //foreach (DictionaryEntry i in sl)
            //{
            //    Console.WriteLine(i.Key.ToString() + ":" + i.Value);
            //}

            //foreach (DictionaryEntry i in sl2)
            //{
            //    Console.WriteLine(i.Key + ":" + i.Value);
            //}

            //Stack stk = new Stack();
            //stk.Push("aaa");
            //stk.Push("bbb");
            //stk.Push("ccc");
            //stk.Push("ddd");
            //Console.WriteLine(stk.Count);
            //Console.WriteLine(stk.Peek());
            //stk.Pop();
            //stk.Pop();
            //foreach (var i in stk)
            //{
            //    Console.WriteLine(i);
            //}

            //Queue q1 = new Queue();

            //q1.Enqueue("aaa");
            //q1.Enqueue("bbb");
            //q1.Enqueue("ccc");
            //q1.Enqueue("ddd");

            //foreach (var i in q1)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(q1.Count);

            //Console.WriteLine(q1.Dequeue());

            //Console.WriteLine(q1.Count);

            //foreach (var i in q1)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(q1.Peek());

            //q1.Clear();
            //Console.WriteLine("Queue cleared...");
            //q1.Enqueue("new element1");
            //q1.Enqueue("new element2");

            //foreach (var i in q1)
            //{
            //    Console.WriteLine(i);
            //}

            //object[] a = q1.ToArray();
            //foreach(var i in a)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(a.GetType());

            //List<int> l1 = new List<int>();
            //l1.Add(10);
            //l1.Add(11);
            //l1.Add(12);
            //l1.Add(13);
            //l1.Add(14);

            //Console.WriteLine(l1.Capacity);
            //Console.WriteLine(l1.Count);

            //foreach(int i in l1)
            //{
            //    Console.WriteLine(i);
            //}

            //Dictionary<int, string> d1 = new Dictionary<int, string>();
            //d1.Add(1, "aaa");
            //d1.Add(2, "aaa");
            //d1.Add(3, "aaa");
            //d1.Add(4, "aaa");
            //d1.Add(5, "aaa");

            //Console.WriteLine(d1.Count);

            //foreach (KeyValuePair<int,string> i in d1)
            //{
            //    Console.WriteLine(i.Key+":"+i.Value);
            //}

            //IDictionaryEnumerator d1enum = d1.GetEnumerator();
            //d1enum.Reset();
            //while (d1enum.MoveNext())
            //{
            //    Console.WriteLine(d1enum);
            //    Console.WriteLine(d1enum.Current);
            //    Console.WriteLine(d1enum.Key+":"+d1enum.Value);
            //}

            //SortedList<string, string> s1 = new SortedList<string, string>();
            //s1.Add("p", "pqr");
            //s1.Add("x", "xyz");
            //s1.Add("a", "abc");

            //foreach (KeyValuePair<string, string> i in s1)
            //{
            //    Console.WriteLine(i.Key + ":" + i.Value);
            //}

            //foreach (object i in s1)
            //{
            //    KeyValuePair<string, string> s2 = (KeyValuePair<string, string>)i;
            //    Console.WriteLine(s2.Key + ":" + s2.Value);
            //    Console.WriteLine(i.ToString());
            //}


            //Stack<string> stk1 = new Stack<string>();
            //stk1.Push("aaa");
            //stk1.Push("bbb");
            //stk1.Push("ccc");
            //stk1.Push("ddd");

            //foreach (string s in stk1)
            //{
            //    Console.WriteLine(s);
            //}

            //Queue<string> q2 = new Queue<string>();

            //q2.Enqueue("aaa");
            //q2.Enqueue("bbb");
            //q2.Enqueue("ccc");
            //q2.Enqueue("ddd");

            //foreach (string i in q2)
            //{
            //    Console.WriteLine(i);
            //}

            //ICollection<string> demo = new List<string>();
            //demo.Add("aaaa");
            //demo.Add("bbbb");
            //demo.Add("cccc");

            //foreach (string i in demo)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();
        }
    }
}
