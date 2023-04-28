using Gym_Management_Website.Models;
using System;                      
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gym_Management_Website.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        readonly ApplicationDbContext _context = new ApplicationDbContext();
        // [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(_context.Members.ToList());
        }
    }
}