using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym_Management_Website.Models; 

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

            return RedirectToAction("Index"); 
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

            return RedirectToAction("Index"); 
        }
    }
}