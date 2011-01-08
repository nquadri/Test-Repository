using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Web.Application;

namespace TestApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewModel.Message = "Welcome to ASP.NET MVC!";
            using (var service = new Service())
            {
                service.DoStuff();
            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
