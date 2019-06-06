<<<<<<< HEAD
﻿using PizzaBox.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Data
{
    public interface ICrud
    {
        List<Users> GetUsers();
        Users GetUser(string id);

        void AddUser(Users u);
        void DeleteUser(Users u);
    }
}
=======
﻿using PizzaBox.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Data
{
    public interface ICrud
    {
        List<Users> GetUsers();
        Users GetUser(string id);

        void AddUser(Users u);
        void DeleteUser(Users u);
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
