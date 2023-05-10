using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gym_Management_Website.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminDashboard()  //click dashboard
        {
            return View(); 
        }
        public ActionResult ManageDrivers() // click maange drivers
        {

            return View(); 
        }

        // The Driver section ___________________________________________________________________________________________________________________________________________________________
        //_______________________________________________________________________________________________________________________________________________________________________________
        public ActionResult DriverDashboard() // click dashboard
        {
            return View(); 
        }
    }
}