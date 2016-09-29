using IOC.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOCWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILibraryDemo _libraryDemo;

        public HomeController(ILibraryDemo libraryDemo)
        {
            _libraryDemo = libraryDemo;
        }

        public string Index()
        {
            var result = _libraryDemo.DemoFunc();
            return result;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}