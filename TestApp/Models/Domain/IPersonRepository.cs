using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.Models.Domain
{
    public interface IPersonRepository
    {
        void Add(Person person);
        void Update(Person person);
        void Remove(Person person);
        Person GetById(int personId);
        Person GetByName(string name);
        IEnumerable<Person> GetAll();
    }
}