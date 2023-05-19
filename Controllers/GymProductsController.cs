using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gym_Management_Website.ViewModels; 
using Gym_Management_Website.Models;

namespace Gym_Management_Website.Controllers
{
    public class GymProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GymProducts
        public ActionResult Index()
        {
            var list = db.gymProductsDatabase.ToList(); 
            return View("Index",list);
        }
        public ActionResult ReadOnlyIndex()
        {

            var list = db.gymProductsDatabase.ToList();

            List<Item> cart = (List<Item>)Session["cart"];
            var counter = 0;
            if(cart == null)
            {
                counter = 0; 
            }
            else
            {
                foreach (var vari in cart)
                {
                    var calc = vari.Quantity;

                    counter = counter + calc;
                }
            }
            
            var vm = new GymProductsListAndCartCountViewModel
            {
                gymprodvm = list,
                countvm = counter
            };
            return View("ReadOnlyIndex", vm); 
        }
        // GET: GymProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GymProducts gymProducts = db.gymProductsDatabase.Find(id);
            if (gymProducts == null)
            {
                return HttpNotFound();
            }
            return View(gymProducts);
        }

        // GET: GymProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GymProducts/Create 
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,prod_name,prod_price,prod_qty,prod_image")] GymProducts gymProducts)
        {
            if (ModelState.IsValid)
            {
                db.gymProductsDatabase.Add(gymProducts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gymProducts);
        }

        // GET: GymProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GymProducts gymProducts = db.gymProductsDatabase.Find(id);
            if (gymProducts == null)
            {
                return HttpNotFound();
            }
            return View(gymProducts);
        }

        // POST: GymProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,prod_name,prod_price,prod_qty,prod_image")] GymProducts gymProducts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gymProducts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gymProducts);
        }

        // GET: GymProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GymProducts gymProducts = db.gymProductsDatabase.Find(id);
            if (gymProducts == null)
            {
                return HttpNotFound();
            }
            return View(gymProducts);
        }

        // POST: GymProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GymProducts gymProducts = db.gymProductsDatabase.Find(id);
            db.gymProductsDatabase.Remove(gymProducts);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult numItemsCart() //This is for the counter of items the user puts in their cart , this is displayed at the home page.
        {

            List<Item> cart = (List<Item>)Session["cart"];
            var counter = 0;
            foreach (var vari in cart)
            {
                var calc = vari.Quantity;

                counter = counter + calc;
            }

            return Content("(" + counter + ")");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
