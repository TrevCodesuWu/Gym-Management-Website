using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gym_Management_Website.Models; 
using System.Web.Mvc;

namespace Gym_Management_Website.Controllers
{
    
    public class AdminController : Controller
    {

        ApplicationDbContext context; 
        
        public AdminController()
        {
            context = new ApplicationDbContext(); 
        }
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

        public ActionResult OrderDrivers()
        {
            var listorders = context.Orderdb.Where(cc => cc.driver.driver_email == User.Identity.Name).ToList(); 

            return View(listorders); 
        }
        public ActionResult CompletedDeliveries()
        {
            return View(); 
        }
        public ActionResult Pickup(int id)
        {
            var fromorder = context.Orderdb.Where(cc => cc.id == id).SingleOrDefault();
            fromorder.deliverystatus = Convert.ToString(status.Arriving);

            context.SaveChanges(); 

            return RedirectToAction("OrderDrivers"); 
        }
        public ActionResult Complete(int id)
        {
            var fromorder = context.Orderdb.Where(cc => cc.id == id).SingleOrDefault();
            fromorder.deliverystatus = Convert.ToString(status.Complete);
            context.SaveChanges();

            return RedirectToAction("OrderDrivers");
        }
    }
}