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
        [HttpGet("secure/person/all")]
        public List<Person> GetPersons()
        {
            return PersonRepository.GetAll();
        }
    }
}