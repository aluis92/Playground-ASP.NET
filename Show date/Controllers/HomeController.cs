using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Show_date.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int day = DateTime.Now.Day;

            ViewBag.Time = "Today is Day " + day;
            return View();
        }
    }
}