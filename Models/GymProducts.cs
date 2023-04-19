using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace Gym_Management_Website.Models
{
    public class GymProducts
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string prod_name { get; set; }
        [Required]
        public double prod_price { get; set; }
        [Required]
        public int prod_qty { get; set; }

    }
}