using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym_Management_Website.Models; 

namespace Gym_Management_Website.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Messages
        private ApplicationDbContext context; 
        public MessagesController()
        {
            context = new ApplicationDbContext(); 
        }
        
        public ActionResult PaymentSuccess()
        {
            List<Item> cart = (List<Item>)Session["cart"]; //storing the list of items(contains a list and a variable) from the session 
            // id prdname prdprice total quantityitem trackingnum
           // var order = new Orderr();  new object of order which is going to be added to the db 
           /* foreach(var itemm in cart)
            {
               itemm.Products.n
            } */

            // Last times code 
            List<String> prodName = new List<String>(); // list of string to contain the product name 
            List<int> quant = new List<int>();  // list of int to get the quantity 
            List<double> totalamt = new List<double>(); // to get the total by multiplying the price of item with the quantity 
            var alltt = 0.00;
            string namequant = "";
            for (var i = 0; i < cart.Count; i++)
            {
                  prodName.Add(cart[i].Products.prod_name);
                var tt = cart[i].Products.prod_price * cart[i].Quantity;
                quant.Add(cart[i].Quantity);
                alltt = alltt + tt;
                namequant += cart[i].Products.prod_name + "(" + cart[i].Quantity + ")\n";
                if(cart.Count - 1 == i)
                {
                    totalamt.Add(alltt);
                }

            }
            ViewBag.Products = (List<string>)prodName;
            ViewBag.Quant = (List<int>)quant;
            ViewBag.Tot = totalamt[0];
            ViewBag.nq = namequant; 

            

            Random random = new Random();
            var TrackingNo = "";

            for (int i = 0; i < 10; i++)
            {
                var Tracking = random.Next(0, 9);
                TrackingNo += Convert.ToString(Tracking);
            }
           
            ViewBag.Trak = TrackingNo;

            var orderdet = new Order()
            {
                NameandQuant = namequant,
                total = alltt,
                tracking_num = TrackingNo,
                userEmail = User.Identity.Name
                
            };
       // was trying to change it for testing//     orderdet.deliverystatus = Convert.ToString(status.Arriving);
            context.Orderdb.Add(orderdet);
            context.SaveChanges();
           
            return View();
        }
        public ActionResult PaymentCanceled()
        {
            return View(); 
        }
    }
}