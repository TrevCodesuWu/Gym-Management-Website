﻿using System;
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

        public ActionResult Index() // logged in users orders except for completed 
        {
           
            var listorder = context.Orderdb.Where(c => c.userEmail == User.Identity.Name).ToList();
            var filtered = listorder.Where(cc => cc.deliverystatus == "Pending" || cc.deliverystatus == "Arriving" || cc.deliverystatus == "Cancelled").ToList();
            return View(filtered);
        }
        public ActionResult UserCompletedOrders()
        {
            var listorder = context.Orderdb.Where(c => c.userEmail == User.Identity.Name).ToList();

            var filteredlist = listorder.Where(ss => ss.deliverystatus == "Complete").ToList();

            return View(filteredlist); 
        }
        public ActionResult allOrders()
        {

            var listorder = context.Orderdb.Where(cc => cc.deliverystatus == "Pending" || cc.deliverystatus == "Arriving" || cc.deliverystatus == "Cancelled").ToList();

            return View(listorder);
        }
        public ActionResult completeOrders()
        {
            var listorder = context.Orderdb.Where(ss => ss.deliverystatus == "Complete").ToList();

            return View(listorder);
        }
    }
}