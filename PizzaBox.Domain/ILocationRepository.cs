using System;
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
