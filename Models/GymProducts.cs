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
        [Display(Name ="Product")]
        public string prod_name { get; set; }
        [Display(Name = "Price")]

        [Required]
        public double prod_price { get; set; }
        [Display(Name = "Quantity")]

        [Required]
        public int prod_qty { get; set; }
        public string prod_image { get; set; }

       

    }
}
// remove from model , create , edit , readonlyindex , controller actionmehod of edit and create in gympro