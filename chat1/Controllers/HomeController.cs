// HomeController.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.AspNetCore.Mvc;


namespace TutorialSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a tutorial website built with C# and ASP.NET MVC.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us for any queries.";

            return View();
        }
    }
}
