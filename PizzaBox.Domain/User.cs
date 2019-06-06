using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{ 
    public class User
    {
        private string username;
        private string password;
        public List<Order> orderHistory { get; set; }
        public DateTime lastOrderTime { get; set; }

        public string Username
        {
            get => username; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("username cannot be empty ");
                }
                username = value;
            }
        }

        public string Password
        {
            get => password; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("password cannot be empty ");
                }
                password = value;
            }
        }
    }
}
