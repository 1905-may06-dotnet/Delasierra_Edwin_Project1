<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class PizzaToppings
    {
        public int Pizzaid { get; set; }
        public int Toppingid { get; set; }

        public virtual Pizza Pizza { get; set; }
        public virtual Toppings Topping { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class PizzaToppings
    {
        public int Pizzaid { get; set; }
        public int Toppingid { get; set; }

        public virtual Pizza Pizza { get; set; }
        public virtual Toppings Topping { get; set; }
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
