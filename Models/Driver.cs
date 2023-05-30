using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gym_Management_Website.Models
{
    public class Driver
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Driver")]
        public string driver_email { get; set; }
        public string phone_num { get; set; }

    }
}