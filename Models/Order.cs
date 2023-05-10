using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace Gym_Management_Website.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        public string userEmail { get; set; }

        public DateTime timeOrder { get; set; }
        [Required]
        public string NameandQuant { get; set; }
        [Required]
        public double total { get; set; }
        public string deliverystatus { get; set; } = Convert.ToString(status.Pending);
        [Required]
        public string tracking_num { get; set; }
        public Order()
        {
            timeOrder = DateTime.Now; 
        }
    }
}
