using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym_Management_Website.Models;

namespace Gym_Management_Website.Controllers
{
    
    public class TrackingController : Controller
    {
        // GET: Tracking
        public ApplicationDbContext context; 
        public TrackingController()
        {
            context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        [Authorize]
        public ActionResult  OrderCategory()
        {
            return View();
        }
        public ActionResult Index() // Tracking Home Page
        {
            return View();
        }
        /*
        [HttpPost]
        public ActionResult Example(string Trac) // trying out this thing if it works 
        {

            return Content("Tracking Number : " + Trac);
        }
        The name in input should be what is put in the parameter if passing one field

         <input type="text" name="Trac" required class="form-control" placeholder="Enter your 10 digits tracking no." />
        */
        [HttpPost]
        public ActionResult Track(string trackingnum)
        {
            var fromOrders = context.Orderdb.Where(cc => cc.tracking_num == trackingnum).SingleOrDefault();
            // checking if the tracking number exists in the order database 

            if (fromOrders == null) // if there is nothing there then return void
            {
                return HttpNotFound();
            }

            // To check what delivery state to give different outputs 
            if (fromOrders.deliverystatus == Convert.ToString(status.Pending))
            {

                return View("Pend",fromOrders);

            }
            else if (fromOrders.deliverystatus == Convert.ToString(status.Arriving))
            {

                return View("Arriv",fromOrders);
            }
            else if (fromOrders.deliverystatus == Convert.ToString(status.Complete))
            {

                return View("Comp",fromOrders);
            }
            else
            {

                return View("Cancel",fromOrders); // This is for cancelled 
            }

        }



    }
}