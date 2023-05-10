using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym_Management_Website.Models; 

namespace Gym_Management_Website.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        private ApplicationDbContext context; 
        public OrderController()
        {
            context = new ApplicationDbContext(); 
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        public ActionResult Index()
        {
           
            var listorder = context.Orderdb.Where(c => c.userEmail == User.Identity.Name).ToList();

            return View(listorder);
        }
    }
}