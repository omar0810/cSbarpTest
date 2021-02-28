using CodingChallenge.Models;
using CodingChallenge.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Services
{
    public class CodingChallengeService : ICodingChallengeService
    {
        public ICodingChallengeRepository _codingChallengeRepository;

        public CodingChallengeService(ICodingChallengeRepository codingChallengeRepository)
        {
            _codingChallengeRepository = codingChallengeRepository;
        }

        public List<Person> GetPeople() => _codingChallengeRepository.GetPeople();
        public void PopulatePersons() => _codingChallengeRepository.PopulatePersons();
        public void Insert() => _codingChallengeRepository.Insert();
    }
}
