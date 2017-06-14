using Cibertec.Web.Filter;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cibertec.Web.Controllers
{
    [ExceptionLoggerFilter]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [Route("Home/Issue")]
        public IActionResult CreateIssue()
        {
            throw new Exception("New error for demostration");
        }
    }
}
