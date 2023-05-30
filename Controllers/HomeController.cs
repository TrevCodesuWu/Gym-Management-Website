using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gym_Management_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("AdminRole"))
            {
                return RedirectToAction("Admindashboard", "Admin");
            }
            if (User.IsInRole("DriverRole"))
            {
                return RedirectToAction("DriverDashboard", "Admin");
            }
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
        public ActionResult CalculatorHome() //Calculator home page goes here in this view 
        {

            return View();
        }
        public ActionResult notFound()
        {
            return View();
        }
    }
}