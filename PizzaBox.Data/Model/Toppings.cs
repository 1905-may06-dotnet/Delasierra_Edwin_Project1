<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class Toppings
    {
        public Toppings()
        {
            PizzaToppings = new HashSet<PizzaToppings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PizzaToppings> PizzaToppings { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class Toppings
    {
        public Toppings()
        {
            PizzaToppings = new HashSet<PizzaToppings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PizzaToppings> PizzaToppings { get; set; }
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
