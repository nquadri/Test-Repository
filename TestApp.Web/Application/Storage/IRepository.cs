using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Web.Application.Storage
{
    public interface IRepository<T>  where T : class
    {
        void Attach(T entity);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Modify(T entity);
        void Delete(T entity);
        void SubmitChanges();
    }
}
