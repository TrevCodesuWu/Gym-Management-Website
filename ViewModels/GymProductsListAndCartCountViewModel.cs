using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gym_Management_Website.Models; 

namespace Gym_Management_Website.ViewModels
{
    public class GymProductsListAndCartCountViewModel
    {
        public List<GymProducts> gymprodvm { get; set; }
        public int countvm { get; set; }

    }
}