<<<<<<< HEAD
﻿using PizzaBox.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Data
{
    public sealed class DbInstance
    {
        private static PizzaContext instance = null;
        private DbInstance()
        {
        }
        public static PizzaContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PizzaContext();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }
    }
}
=======
﻿using PizzaBox.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Data
{
    public sealed class DbInstance
    {
        private static PizzaContext instance = null;
        private DbInstance()
        {
        }
        public static PizzaContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PizzaContext();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
