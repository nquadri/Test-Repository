using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models.Domain;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonRepository _repository;
        public HomeController()
        {
            _repository = new PersonRepository();
        }

        public ActionResult Index()
        {
            var people = _repository.GetAll();
            ViewModel.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
