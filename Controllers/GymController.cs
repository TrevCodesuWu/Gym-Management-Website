using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gym_Management_Website.Controllers
{
    public class GymController : Controller
    {
        // GET: Gym
        public ActionResult GymHome()
        {
            return View();
        }

    }
}