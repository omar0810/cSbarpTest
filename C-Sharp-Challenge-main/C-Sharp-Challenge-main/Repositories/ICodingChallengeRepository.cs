using CodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Repositories
{
    public interface ICodingChallengeRepository
    {
        List<Person> GetPeople();
        void PopulatePersons();
        void Insert();
    }
}
