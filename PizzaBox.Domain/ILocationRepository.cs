<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public interface ILocationRepository
    {
        void AddLocation(Location location);
        void DeleteLocation(int id);
        void EditLocation(Location location);
        IEnumerable<Location> GetAllLocations();
        Location GetLocation(int id);
        decimal GetTotalSales(Location location);
        void Save();
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public interface ILocationRepository
    {
        void AddLocation(Location location);
        void DeleteLocation(int id);
        void EditLocation(Location location);
        IEnumerable<Location> GetAllLocations();
        Location GetLocation(int id);
        decimal GetTotalSales(Location location);
        void Save();
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
