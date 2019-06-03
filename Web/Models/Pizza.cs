using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Web.Models
{
    public class Pizza
    {
        [DisplayName("Size")]
        [Required(ErrorMessage = "Size cannot be blank")]
        [StringLength(10, ErrorMessage = "Size should have no more than 10 characters")]
        public string size { get; set; }
        [DisplayName("Crust")]
        [Required(ErrorMessage = "Size cannot be blank")]
        [StringLength(10, ErrorMessage = "Crust should have no more than 10 characters")]
        public string crust { get; set; }
    }
}
