using CodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Repositories
{
    public class CodingChallengeRepository : ICodingChallengeRepository
    {
        // This is meant to mock a database table
        public List<Person> People = new List<Person>();
        
        public List<Person> GetPeople()
        {
            return People;
        }

        private int CalcAge(string db)
        {
            DateTime date = DateTime.Now;
            int year = date.Year; ;
            
            return year - Convert.ToInt32(db);
        }

        public void Insert()
        {
            // this wwill add new person if not exist
            bool bAdd = true;
            foreach (Person pr in People)
            {
                if(pr.FirstName.ToLower() == "Jack".ToLower() && pr.LastName.ToLower() == "Thompson".ToLower())
                {
                    bAdd = false;
                    break;
                }

            }
            if (bAdd)
            {
                var JackH = new Person
                {
                    FirstName = "Jack",
                    LastName = "Thompson",
                    DateOfBirth = new DateTime(1976, 11, 22),
                    Age = CalcAge("1976"),
                    Friends = new List<string> { "John", "Jose", "Ahmed" },
                };
                People.Add(JackH);
            }
             
        }
        public void PopulatePersons()
        {

            People = new List<Person>();
            var personA = new Person
            {
                FirstName = "John",
                LastName = "Smith",
                DateOfBirth = new DateTime(1966, 11, 22),
                Age = CalcAge("1966"),
                Friends = new List<string> { "Jessica", "Jose", "Ahmed" },
            };
            

            var personB = new Person
            {
                FirstName = "Jessica",
                LastName = "Johnson",
                DateOfBirth = new DateTime(1986, 03, 11),
                Age = CalcAge("1986"),
                Friends = new List<string> { "John", "Jose", "Ahmed" },
            };

            var personC = new Person
            {
                FirstName = "Jose",
                LastName = "Valdes",
                DateOfBirth = new DateTime(2001, 01, 08),
                Age = CalcAge("2001"),
                Friends = new List<string> { "Jessica", "John", "Ahmed" },
            };

            var AhmedH = new Person
            {
                FirstName = "Ahmed",
                LastName = "Hussein",
                DateOfBirth = new DateTime(1974, 01, 08),
                Age = CalcAge("1974"),
                Friends = new List<string> { "Jessica", "Jose", "John" },
            };
            People.Add(personA);
            People.Add(personB);
            People.Add(personC);
            People.Add(AhmedH);
        }
    }
}
