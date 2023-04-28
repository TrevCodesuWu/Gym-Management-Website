using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gym_Management_Website.Models; 

namespace Gym_Management_Website.ViewModels
{
    public class MemberAndTotalViewModel
    {
        public Member memberVm { get; set; }
        public double totalVm { get; set; }

    }
}