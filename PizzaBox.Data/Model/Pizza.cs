<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
            PizzaToppings = new HashSet<PizzaToppings>();
        }

        public int Id { get; set; }
        public string Crust { get; set; }
        public string Size { get; set; }
        public decimal Cost { get; set; }

        public virtual ICollection<PizzaOrder> PizzaOrder { get; set; }
        public virtual ICollection<PizzaToppings> PizzaToppings { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
            PizzaToppings = new HashSet<PizzaToppings>();
        }

        public int Id { get; set; }
        public string Crust { get; set; }
        public string Size { get; set; }
        public decimal Cost { get; set; }

        public virtual ICollection<PizzaOrder> PizzaOrder { get; set; }
        public virtual ICollection<PizzaToppings> PizzaToppings { get; set; }
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
