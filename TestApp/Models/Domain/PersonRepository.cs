using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Criterion;
using TestApp.Models.Helper;

namespace TestApp.Models.Domain
{
    public class PersonRepository : IPersonRepository
    {
        #region IPersonRepository Members

        public void Add(Person person)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(person);
                transaction.Commit();
            }
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }

        public void Remove(Person person)
        {
            throw new NotImplementedException();
        }

        public Person GetById(int personId)
        {
            throw new NotImplementedException();
        }

        public Person GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var people = session
                    .CreateCriteria(typeof(Person))
                    .List<Person>();
                return people;
            }
        }

        #endregion
    }
}