using System.Collections.Generic;
using DotnetAndDocker.Models;

namespace DotnetAndDocker.Repositories
{
    public interface IPersonRepository
    {
        Person GetById(int id);
        List<Person> GetAll();
        int GetCount();
        void Remove();
        string Save(Person person);
    }
}