using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb_ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Student()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Course()
        {
            ViewBag.Message = "Your course page.";

            return View();
        }
        public ActionResult Enrollment()
        {
            ViewBag.Message = "Your enrollment page.";

            return View();
        }
    }
}