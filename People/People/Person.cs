using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int dayBorn;
        private int monthBorn;
        private int yearBorn;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int DayBorn
        {
            get { return dayBorn; }
            set { dayBorn = value; }
        }

        public int MonthBorn
        {
            get { return monthBorn; }
            set { monthBorn = value; }
        }

        public int YearBorn
        {
            get { return yearBorn; }
            set { yearBorn = value; }
        }


        public string DateOfBirth()
        {
            return string.Format("{0}/{1}/{2}", dayBorn, monthBorn, yearBorn);
        }

        public bool HadThisYearsBirthday()
        {
            DateTime today = DateTime.Today;

            bool returnValue = false;

            if (today.Month > monthBorn)

            {
                returnValue = true;
            }

            else if (today.Month == monthBorn)
            {
                if (today.Day >= dayBorn)
                {
                    returnValue = true;
                }
            }
            return returnValue;
        }

        public DateTime GetNextBirthday()
        {
            DateTime today = DateTime.Today;

            int birthdayYear = today.Year;

            if (HadThisYearsBirthday())
            {
                birthdayYear++;
            }

            DateTime nextBirthday =
                new DateTime(birthdayYear, monthBorn, dayBorn);
            return nextBirthday;
        }

        public int HowManyDaysTillBirthday()
        {
            DateTime nextBirthday = GetNextBirthday();
            DateTime today = DateTime.Today;

            TimeSpan difference = 
                nextBirthday.Subtract(today);

            int daysToBirthday = difference.Days;

            return daysToBirthday;

        }

        public Person(string firstName, string lastName, int dayBorn, int monthBorn, int yearBorn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dayBorn = dayBorn;
            this.monthBorn = monthBorn;
            this.yearBorn = yearBorn;
        }
    }
}

