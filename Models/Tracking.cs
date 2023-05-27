using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Gym_Management_Website.Models
{
    public class Tracking
    {
        [Display(Name="Tracking Number")]
        [Required]
        public string TrackingNumber { get; set; }

    }
}