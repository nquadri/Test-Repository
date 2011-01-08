using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Web;
using TestApp.Web.Application.Model;

namespace TestApp.Web.Application.Storage
{
    public class Repository<T> : IRepository<T>  where T : class
    {
        ObjectSet<T> _objectSet;

        public Repository()
        {
            _objectSet = new VISTEntities().CreateObjectSet<T>();
        }

        public Repository(ObjectContext objectContext)
        {
            _objectSet = objectContext.CreateObjectSet<T>();
        }

        public void Attach(T entity)
        {
            _objectSet.Attach(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _objectSet;
        }

        public void Add(T entity)
        {
            _objectSet.Add(entity);
        }

        public void Modify(T entity)
        {
            _objectSet.Modify(entity);
        }

        public void Delete(T entity)
        {
            _objectSet.Delete(entity);
        }

        public void SubmitChanges()
        {
            _objectSet.Context.SaveChanges();
        }
    }
}