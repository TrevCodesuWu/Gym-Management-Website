using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym_Management_Website.Models;
using Gym_Management_Website.ViewModels; 

namespace Gym_Management_Website.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext context; 
        public CartController()
        {
            context = new ApplicationDbContext(); 
        }
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddToCart(int id)
        {
            if(Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                Item item = new Item(); 
                var fromdb = context.gymProductsDatabase.SingleOrDefault(c => c.id == id);
                item.Products = fromdb;
                item.Quantity = 1;

                cart.Add(item);

                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                var indexI = IsInCart(id); 
                if(indexI != -1)
                {
                    cart[indexI].Quantity++; 
                } else
                {
                    Item item = new Item();
                    var itemindb = context.gymProductsDatabase.SingleOrDefault(c => c.id == id);
                    item.Products = itemindb;
                    item.Quantity = 1;

                    cart.Add(item);

                }
                Session["cart"] = cart;

            }
            List<Item> cartv = (List<Item>)Session["cart"];
            

            return Json(cartv, JsonRequestBehavior.AllowGet);

        }

        public int IsInCart(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"]; 
            
            for(var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Products.id == id)
                {
                    return i; 
                }

            }

            return -1; 
        }
        public ActionResult RemoveFromCart(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            var indexI = IsInCart(id);
            cart.RemoveAt(indexI);
            Session["cart"] = cart;

            List<Item> cartv = (List<Item>)Session["cart"];

            return Json(cartv, JsonRequestBehavior.AllowGet);

        }

         [Authorize]
        public ActionResult confirmCheckout(double totalAmount)
        {
            var memberfromdb = context.Members.Where(c => c.Email == User.Identity.Name).SingleOrDefault();
            if(memberfromdb == null)
            {
                return HttpNotFound(); 
            }
            var vm = new MemberAndTotalViewModel
            {
                totalVm = totalAmount,
                memberVm = memberfromdb
            };
            return View(vm); //returns a view model of total and a member from the db to show the user information and their total . next step is payment(paypal probably) 
        }

        public ActionResult numItemsCart() //This is for the counter of items the user puts in their cart , this is displayed at the home page.
        {
           
            List<Item> cart = (List<Item>)Session["cart"]; // gets all the items in the cart currently 
            var counter = 0; // initializing a new variable 
            foreach( var vari in cart)  // looping throughout the cart 
            {
                var calc = vari.Quantity;

                counter = counter + calc;
            }

            return Content("("+counter+")"); 
        }
        /*Checkout
        public ActionResult Checkout(decimal totalAmount)
        {
            double OrderTotal = Convert.ToDouble(totalAmount);
            string LoggedUserId = User.Identity.GetUserId();
            Member member = _db.Members.Where(m => m.UserId == LoggedUserId).FirstOrDefault();
            if (member != null)
            {
                ViewBag.Name = member.FullName;
                ViewBag.Phone = member.PhoneNo;
                ViewBag.Address = member.Address;
                ViewBag.Email = member.Email;
                ViewBag.Total = OrderTotal;
            }
            return View();
        } */
    }
}