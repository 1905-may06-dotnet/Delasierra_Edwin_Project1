using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Web.Models
{
    public class User
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = "Username cannot be blank")]
        [StringLength(20, ErrorMessage = "Username should have no more than 20 characters")]
        public string Username { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password cannot be blank")]
        public string Password { get; set; }
    }
}
