using CodingChallenge.Models;
using CodingChallenge.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Controllers
{
    [Route("api/CodingChallenge")]
    [ApiController]
    public class CodingChallengeController : ControllerBase
    {
        private readonly ICodingChallengeService _codingChallengeService;
        public CodingChallengeController(ICodingChallengeService codingChallengeService)
        {
            _codingChallengeService = codingChallengeService;
        }

        [HttpGet("Populate")]
        public void Populate()
        {
            _codingChallengeService.PopulatePersons();
        }

        [HttpPost("Insert")]
        
        //Ahmed
        public void Insert()
        {
            _codingChallengeService.Insert();
        }

        [HttpGet("People")]
        public List<Person> Get()
        {
            return _codingChallengeService.GetPeople();
        }
    }
}
