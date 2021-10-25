/*1.Create a reference type called Person.
Populate the Person class with the following properties to store the following information:
First name
Last name
Email address
Date of birth

Add constructors that accept the following parameter lists:
1.All four parameters
2. First, Last, Email
3. First, Last, Date of birth

Add read-only properties that return the following computed information:
1.Adult – whether or not the person is over 18
2. Sun sign – the traditional western sun sign of this person
3. Chinese sign – the chinese astrological sign (animal) of this person
4. Birthday – whether or not today is the person’s birthday
5. Screen name – a default screen name that you might see being offered to a first time user of AOL or Yahoo
(e.g.John Doe born on Feburary 25th, 1980 might be jdoe225 or johndoe022580)

Access these things from Console Application in the Main Function. Accept this data for 5 person and display the same.
Means create an object Array of 5 size and accept these details and display these details in tabular format.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Assignment
    {
        static void Main(string[] args)
        {
            Person.Person[] arr = new Person.Person[5];
            string firstname, lastname, email;
            DateTime dateofbirth;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter Person{i + 1}'s Details...");
                Console.WriteLine("Enter Person's First Name:");
                firstname = Console.ReadLine();
                Console.WriteLine("Enter Person's Last Name:");
                lastname = Console.ReadLine();
                Console.WriteLine("Enter Person's Email:");
                email = Console.ReadLine();
                Console.WriteLine("Enter Person's Date of Birth(DD/MM/YYYY):");
                dateofbirth = DateTime.Parse(Console.ReadLine());
                arr[i] = new Person.Person(firstname, lastname, email, dateofbirth);
            }
            Console.WriteLine("Screen Name | Is Adult? | Is Birthday Today? | Sun Sign | Chinese Sign");
            Console.WriteLine("-----------------------------------------------------------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].ScreenName} | {arr[i].Adult} | {arr[i].Birthday} | {arr[i].SunSign} | {arr[i].ChineseSign}");
            }
            Console.ReadKey();
        }
    }
}
