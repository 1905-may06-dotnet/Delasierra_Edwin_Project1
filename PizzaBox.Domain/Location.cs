<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class Address
    {
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
    }

    public class Location
    {
        public int locationID { get; set; }
        public string name { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
        public List<Order> orders { get; set; }
        public double sales { get; set; }
        public List<int> inventory { get; set; }
        
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class Address
    {
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
    }

    public class Location
    {
        public int locationID { get; set; }
        public string name { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
        public List<Order> orders { get; set; }
        public double sales { get; set; }
        public List<int> inventory { get; set; }
        
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
