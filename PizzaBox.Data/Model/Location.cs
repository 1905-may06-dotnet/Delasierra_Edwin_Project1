<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class Location
    {
        public Location()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class Location
    {
        public Location()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
