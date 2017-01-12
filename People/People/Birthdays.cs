using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Birthdays
    {
       private List<Person> people = new List<Person>();

       private int currentPerson = 0;

        public string GetPersonsFirstName()
        {
            return people[currentPerson].FirstName;
        }

        public string GetPersonsLastName()
        {
            return people[currentPerson].LastName;
        }

        public string GetPersonsDateOfBirth()
        {
            return people[currentPerson].DateOfBirth();
        }

        public bool IsNextPerson()
        {
            if (currentPerson < (people.Count - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPreviousPerson()
        {
            if (currentPerson > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StepToNextPerson()
        {
            if (IsNextPerson())
            {
                currentPerson++;
            }

        }

        public void StepToPreviousPerson()
        {
            if (IsPreviousPerson())
            {
                currentPerson--;
            }
        }

        public void AddPerson(string firstName, string lastName, int dayBorn, int monthBorn, int yearBorn)
        {
            Person person = new Person(firstName, lastName, dayBorn, monthBorn, yearBorn);

           

            people.Add(person);

            
        }

        public string UpcomingBirthdays(int days)
        {
            // we create a string containing the names and dates for
            // all the people whose birthdays are within the next number of days

            // we start with no names
            string names = "";

            // now we look through the list of people
            // we can use a foreach loop here.

            foreach (Person person in people)
            {

                if (person.HowManyDaysTillBirthday() <= days)
                {
                    // here we add the person to the list
                    //
                    // we want the name to be on seperate lines so if
                    // the list is not empty, we start a new line

                    if (names != "")
                    {
                        names = names + Environment.NewLine;
                    }


                    names = names + person.FirstName + " " + person.LastName + " " + person.DateOfBirth();
                }
            }


            return names;
        }

    }
}
