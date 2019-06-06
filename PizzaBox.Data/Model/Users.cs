<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
