using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Web.Models
{
    public class Order
    {
        [DisplayName("Order ID")]
        [Required(ErrorMessage = "Order ID cannot be blank")]
        [StringLength(20, ErrorMessage = "Username should have no more than 20 characters")]
        public int id { get; set; }
        [DisplayName("Location ID")]
        [Required(ErrorMessage = "Location ID cannot be blank")]
        public int locationid { get; set; }
        [DisplayName("User ID")]
        [Required(ErrorMessage = "User ID cannot be blank")]
        public string userid { get; set; }
        [DisplayName("Time of Order")]
        [Required(ErrorMessage = "Order time cannot be blank")]
        public DateTime orderTime { get; set; }
        [DisplayName("Total Cost")]
        [Required(ErrorMessage = "Total cost cannot be blank")]
        public decimal cost { get; set; }
    }
}
