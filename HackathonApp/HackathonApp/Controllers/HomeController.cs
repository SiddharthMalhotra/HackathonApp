using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HackathonApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public string Index1()
        {
            return "Hello";

        }
    }
}
