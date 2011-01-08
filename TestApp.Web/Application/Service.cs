using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using TestApp.Web.Application.Model;
using TestApp.Web.Application.Storage;

namespace TestApp.Web.Application
{
    public class Service : IDisposable
    {
        private readonly IRepository<Voter> _repository = new Repository<Voter>();
        public void DoStuff()
        {

            using (var transactionScope = new System.Transactions.TransactionScope())
            {
                var voter = _repository.GetAll().Where(v => v.Certnum == "111111").FirstOrDefault();
                voter.FirstName = "Modified";
                _repository.Modify(voter);
                _repository.Add(new Voter
                                    {
                                        Certnum = "2222551",
                                        LastName = "Test1",
                                        FirstName = "Test2",
                                        Birthdate = Convert.ToDateTime("01/01/1980"),
                                        Status = "A"
                                    });
                _repository.SubmitChanges();
                transactionScope.Complete();
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}