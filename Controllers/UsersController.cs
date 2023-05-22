using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym_Management_Website.Models;
using Gym_Management_Website.ViewModels;
using System.Data.Entity;

namespace Gym_Management_Website.Controllers
{
    public class UsersController : Controller
    {

        private ApplicationDbContext context;
        public UsersController()
        {
            context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        [Authorize]
        public ActionResult ListUsers()
        {
            var list = context.userDatabase.Where(rr => rr.EmailLogin == User.Identity.Name).Include(cc => cc.gender).ToList();

            return View(list);
        }
        /* public ActionResult UserDetails(int id)
         {
             var fromdb = context.userDatabase.SingleOrDefault(c => c.id == id);
             if(fromdb == null)
             {
                 return HttpNotFound(); 
             }

             double BMR;
             string message;
             if (fromdb.GenderId == 1)
             {
                 BMR = 88.362 + (13.38 * fromdb.weight) + (4.8 * fromdb.height) - (5.67 * fromdb.age);
                 message = "This is specifically calculated for men ";
             }
             else
             {
                 BMR = 447.59 + (9.24 * fromdb.weight) + (3.09 * fromdb.height) - (4.33 * fromdb.age);
                 message = "This is specifically calculated for women ";

             }

             return Content("The BMR for " + fromdb.EmailLogin + "  is " + BMR + ". " + message); 
         } */
        [Authorize]

        public ActionResult Calcform()
        {

            var vm = new UserGenderViewModel
            {
                genderList = context.genderDatabase.ToList(),

            };

            return View(vm);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize]

        public ActionResult formsubmit(User user)
        {

            if (!ModelState.IsValid)
            {
                var vm = new UserGenderViewModel
                {
                    genderList = context.genderDatabase.ToList(),
                    user = user
                };
                return View("Calcform", vm);
            }
            user.log = DateTime.Now;

            user.EmailLogin = User.Identity.Name;
            context.userDatabase.Add(user);
            context.SaveChanges();

            var userid = user.id;

            var userfromdb = context.userDatabase.SingleOrDefault(c => c.id == userid);

            if (userfromdb == null)
            {
                return HttpNotFound();
            }

            double BMI;
            string message;

            if (userfromdb.GenderId == 1)

            {
                BMI = (userfromdb.height / 100 * userfromdb.height / 100);
                BMI = userfromdb.weight / BMI;

                message = "This is specifically calculated for men. BMI can be a screening tool, but it does not diagnose the body fatness or health of an individual. To determine if BMI is a health risk, a healthcare provider performs further assessments. Such assessments include skinfold thickness measurements, evaluations of diet and physical activity.";
            }
            else
            {
                BMI = (userfromdb.height / 100 * userfromdb.height / 100);
                BMI = userfromdb.weight / BMI;

                message = "This is specifically calculated for women. BMI can be a screening tool, but it does not diagnose the body fatness or health of an individual. To determine if BMI is a health risk, a healthcare provider performs further assessments. Such assessments include skinfold thickness measurements, evaluations of diet and physical activity";
            }

            var Vm = new BMIuserViewModel
            {
                user_vm = userfromdb,
                message_vm = message,
                bmi_vm = BMI
            };

            return View("BMIview", Vm);
            // return RedirectToAction("ListUsers", "Users");  
        }

        [Authorize]

        public ActionResult delete(int id)
        {
            var fromdb = context.userDatabase.SingleOrDefault(c => c.id == id);
            if (fromdb == null)
            {
                return HttpNotFound();
            }
            context.userDatabase.Remove(fromdb);
            context.SaveChanges();

            return RedirectToAction("ListUsers", "Users");
        }
        public ActionResult Nutri(double bmiUser) // Link to nutrition views 
        {
            if(bmiUser <= 18.5)
            {
                ViewBag.bmiU = bmiUser;
                return View("Under");
            }else if(bmiUser > 18.5 && bmiUser <= 25)
            {
                ViewBag.bmiU = bmiUser;

                return View("Norm");

            }else if(bmiUser > 25 && bmiUser <= 30)
            {
                ViewBag.bmiU = bmiUser;

                return View("Over");
            }
            else
            {
                ViewBag.bmiU = bmiUser;

                return View("Obes");
            }

        }
        /*
        public ActionResult GetData()
        {
            var listUsers = context.userDatabase.Where(c => c.EmailLogin == User.Identity.Name).ToList(); 
          

            return Json(new { data = listUsers}, JsonRequestBehavior.AllowGet);
        }
        */
    }

}