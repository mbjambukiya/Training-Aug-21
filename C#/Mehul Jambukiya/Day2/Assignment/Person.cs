using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        string firstname, lastname, email;
        DateTime dateofbirth, march, april, may, jun, jul, aug, sept, oct, nov, dec, jan1, jan2, feb;
        string adult, sunsign, chinesesign, birthday, screenname;
        string[] chinesesigns = { "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Hourse", "Got", "Monkey" };

        public Person()
        {

        }
        public Person(string firstname, string lastname, string email, DateTime dateofbirth)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.dateofbirth = dateofbirth;
            setdetails();
        }

        public Person(string firstname, string lastname, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }

        public Person(string firstname, string lastname, DateTime dateofbirth)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dateofbirth = dateofbirth;
            setdetails();
        }

        public string Adult
        {
            get { return adult; }
        }
        public string SunSign
        {
            get { return sunsign; }
        }
        public string ChineseSign
        {
            get { return chinesesign; }
        }
        public string Birthday
        {
            get { return birthday; }
        }
        public string ScreenName
        {
            get { return screenname; }
        }

        public void setdetails()
        {
            if (DateTime.Now.Year - dateofbirth.Year > 18)
            {
                adult = "yes";
            }
            else
            {
                adult = "no";
            }

            if (dateofbirth == DateTime.Now.Date)
            {
                birthday = "yes";
            }
            else
            {
                birthday = "no";
            }

            march = new DateTime(dateofbirth.Year, 03, 21);
            april = new DateTime(dateofbirth.Year, 04, 19);
            may = new DateTime(dateofbirth.Year, 05, 20);
            jun = new DateTime(dateofbirth.Year, 06, 21);
            jul = new DateTime(dateofbirth.Year, 07, 22);
            aug = new DateTime(dateofbirth.Year, 08, 22);
            sept = new DateTime(dateofbirth.Year, 09, 22);
            oct = new DateTime(dateofbirth.Year, 10, 22);
            nov = new DateTime(dateofbirth.Year, 11, 22);
            dec = new DateTime(dateofbirth.Year, 12, 21);
            jan1 = new DateTime(dateofbirth.Year + 1, 01, 19);
            jan2 = new DateTime(dateofbirth.Year, 01, 19);
            feb = new DateTime(dateofbirth.Year, 02, 18);

            if (dateofbirth >= march & dateofbirth <= april)
            {
                sunsign = "Aries";
            }
            else if (dateofbirth > april & dateofbirth <= may)
            {
                sunsign = "Taurus";
            }
            else if (dateofbirth > may & dateofbirth <= jun)
            {
                sunsign = "Gemini";
            }
            else if (dateofbirth > jun & dateofbirth <= jul)
            {
                sunsign = "Cancer";
            }
            else if (dateofbirth > jul & dateofbirth <= aug)
            {
                sunsign = "Leo";
            }
            else if (dateofbirth > aug & dateofbirth <= sept)
            {
                sunsign = "Virgo";
            }
            else if (dateofbirth > sept & dateofbirth <= oct)
            {
                sunsign = "Libra";
            }
            else if (dateofbirth > oct & dateofbirth <= nov)
            {
                sunsign = "Scorpio";
            }
            else if (dateofbirth > nov & dateofbirth <= dec)
            {
                sunsign = "Sagittarius";
            }
            else if (dateofbirth > dec & dateofbirth <= jan1)
            {
                sunsign = "Capricorn";
            }
            else if (dateofbirth > jan2 & dateofbirth <= feb)
            {
                sunsign = "Aquarius";
            }
            else if (dateofbirth > feb & dateofbirth <= march)
            {
                sunsign = "Pisces";
            }

            for (int i = 1981, j = 0; i <= 1992; i++, j++)
            {
                for (int k = i; k <= dateofbirth.Year; k += 12)
                {
                    if (dateofbirth.Year == k)
                    {
                        chinesesign = chinesesigns[j];
                        break;
                    }
                }
            }

            screenname = firstname.ToLower() + dateofbirth.Day.ToString() + dateofbirth.Month.ToString();
        }

    }
}
