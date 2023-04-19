using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gym_Management_Website.Models; 

namespace Gym_Management_Website.Models
{
    public class Item
    {
        public GymProducts Products { get; set; }
        public int Quantity { get; set; }

    }
}