//4.Accept 10 student Name, Address, Hindi, English, Maths Marks ,do the total 
// and compute Grade. Note do it with Array and display the result in grid format

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Student
    {
        string name, address, grade;
        float percentage;
        int hindimarks, englishmarks, mathsmarks, total;

        public Student(string name, string address, int hindimarks, int englishmarks, int mathsmarks)
        {
            this.name = name;
            this.address = address;
            this.hindimarks = hindimarks;
            this.englishmarks = englishmarks;
            this.mathsmarks = mathsmarks;

            total = hindimarks + englishmarks + mathsmarks;
            percentage = total / 3;
            if (percentage > 90)
            {
                grade = "A+";
            }
            else if (percentage > 80 & percentage <= 90)
            {
                grade = "A";
            }
            else if (percentage > 70 & percentage <= 80)
            {
                grade = "B+";
            }
            else if (percentage > 55 & percentage <= 70)
            {
                grade = "B";
            }
            else if (percentage > 40 & percentage <= 55)
            {
                grade = "C";
            }
            else if (percentage > 35 & percentage <= 40)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

        }
        public void display()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"{name}|{address}|{hindimarks}|{englishmarks}|{mathsmarks}|{total}|{percentage}|{grade}");
        }
    }
    class Assignment4
    {
        static void Main(string[] args)
        {
            string name, address;
            int hindimarks, englishmarks, mathsmarks;
            Student[] studata = new Student[1];
            for (int i = 0; i < studata.Length; i++)
            {
                Console.WriteLine("Enter Name of student :");
                name = Console.ReadLine();
                Console.WriteLine("Enter Address of student :");
                address = Console.ReadLine();
                Console.WriteLine("Enter marks of hindi subject out of 100 :");
                hindimarks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter marks of english subject out of 100 :");
                englishmarks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter marks of maths subject out of 100 :");
                mathsmarks = Convert.ToInt32(Console.ReadLine());

                studata[i] = new Student(name, address, hindimarks, englishmarks, mathsmarks);
            }
            Console.WriteLine("Name|Address|Hindi|English|Maths|Total Marks|Percentage|Grade");
            for (int i = 0; i < studata.Length; i++)
            {
                studata[i].display();
            }
            Console.ReadKey();

        }
	}
}
