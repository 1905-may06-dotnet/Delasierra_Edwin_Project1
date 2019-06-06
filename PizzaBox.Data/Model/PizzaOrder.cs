<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class PizzaOrder
    {
        public int Orderid { get; set; }
        public int Pizzaid { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Model
{
    public partial class PizzaOrder
    {
        public int Orderid { get; set; }
        public int Pizzaid { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
