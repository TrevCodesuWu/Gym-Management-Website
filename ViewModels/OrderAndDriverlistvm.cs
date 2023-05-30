using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gym_Management_Website.Models; 

namespace Gym_Management_Website.ViewModels
{
    public class OrderAndDriverlistvm
    {
        public Order ordervm { get; set; }
        public IEnumerable<Driver> driverlist { get; set; }

    }
}