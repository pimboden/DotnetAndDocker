using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DotnetAndDocker.Attributes;
using DotnetAndDocker.Models;
using DotnetAndDocker.Repositories;
namespace DotnetAndDocker.Controllers
{
    [ServiceFilter(typeof(AuthenticationFilterAttribute))]
    public class SecurePersonController : Controller
    {
        private readonly IPersonRepository _personRepository;
 
        public SecurePersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet("secure/person/all")]
        public List<Person> GetPersons()
        {
            return _personRepository.GetAll();
        }
    }
}