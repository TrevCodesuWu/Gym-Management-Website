using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gym_Management_Website.Models;

namespace Gym_Management_Website.ViewModels
{
    public class UserGenderViewModel
    {
        public User user { get; set; }
        public IEnumerable<Gender> genderList { get; set; }

    }
}