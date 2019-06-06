using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Web.Models
{
    public class Location
    {
        [DisplayName("Location ID")]
        [Required(ErrorMessage = "Location ID cannot be blank")]
        public int id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name cannot be blank")]
        [StringLength(50, ErrorMessage = "Name should have no more than 50 characters")]
        public string name { get; set; }

        [DisplayName("Street 1")]
        [Required(ErrorMessage = "Street 1 cannot be blank")]
        [StringLength(50, ErrorMessage = "Street 1 should have no more than 50 characters")]
        public string street1 { get; set; }

        [DisplayName("Street 2")]
        [StringLength(50, ErrorMessage = "Street 2 should have no more than 50 characters")]
        public string street2 { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "City cannot be blank")]
        [StringLength(30, ErrorMessage = "Name should have no more than 30 characters")]
        public string city { get; set; }

        [DisplayName("State")]
        [Required(ErrorMessage = "State cannot be blank")]
        [StringLength(30, ErrorMessage = "State should have no more than 30 characters")]
        public string state { get; set; }

        [DisplayName("Zipcode")]
        [Required(ErrorMessage = "Zipcode cannot be blank")]
        [StringLength(10, ErrorMessage = "Zipcode should have no more than 10 characters")]
        public string zipcode { get; set; }
    }
}
