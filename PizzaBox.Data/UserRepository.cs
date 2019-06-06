<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;
using PizzaBox.Domain;
using System.Linq;

namespace PizzaBox.Data
{
    public class UserRepository : IUserRepository, IOrderRepository, ILocationRepository
    {
        private readonly Model.PizzaContext _db;
        public UserRepository(Model.PizzaContext db)
        {
            _db = db;
        }

        public void AddLocation(Location location)
        {
            _db.Location.Add(Mapper.Map(location));
            Save();
        }

        public void AddOrder(PizzaBox.Domain.Order order)
        {
            _db.Orders.Add(Mapper.Map(order));
            Save();
        }

        public void AddUser(PizzaBox.Domain.User user)
        {
            _db.Users.Add(Mapper.Map(user));
            Save();
        }

        public decimal ComputeOrderCost(PizzaBox.Domain.Order order)
        {
            var list = order.pizzas;
            decimal cost = 0;
            foreach (PizzaBox.Domain.Pizza pizza in list)
            {
                cost += pizza.cost;
            }
            return cost;
        }

        public void DeleteLocation(int id)
        {
            _db.Location.Remove(_db.Location.Find(id));
            Save();
        }

        public void DeleteOrder(int id)
        {
            _db.Orders.Remove(_db.Orders.Find(id));
            Save();
        }

        public void DeleteUser(string username)
        {
            _db.Users.Remove(_db.Users.Find(username));
            Save();
        }

        public void EditLocation(Location location)
        {
            if (_db.Location.Find(location.locationID) != null)
            {
                _db.Location.Update(Mapper.Map(location));
                Save();
            }
        }

        public void EditOrder(Order order)
        {
            if (_db.Orders.Find(order.id) != null)
            {
                _db.Orders.Update(Mapper.Map(order));
                Save();
            }
        }

        public void EditUser(User user)
        {
            if (_db.Users.Find(user.Username) != null)
            {
                _db.Users.Update(Mapper.Map(user));
                Save();
            }
        }

        public IEnumerable<Location> GetAllLocations()
        {
            return _db.Location.Select(x => Mapper.Map(x));
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _db.Orders.Select(x => Mapper.Map(x));
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _db.Users.Select(x => Mapper.Map(x));
        }

        public Location GetLocation(int id)
        {
            var element = _db.Location.Where(a => a.Id == id).FirstOrDefault();

            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }

        public Order GetOrder(int id)
        {
            var element = _db.Orders.Where(a => a.Id == id).FirstOrDefault();

            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }

        public List<Order> GetOrdersByLocation(int locationid)
        {
            var orders = GetAllOrders();
            List<Order> locationOrders = new List<Order>();
            foreach (Order order in orders)
            {
                if (order.locationId == locationid)
                    locationOrders.Add(order);
            }
            if (locationOrders.Count == 0)
                return null;
            return locationOrders;
        }

        public List<Order> GetOrdersByUser(string username)
        {
            var orders = GetAllOrders();
            List<Order> userOrders = new List<Order>();
            foreach (Order order in orders)
            {
                if (order.userId == username)
                    userOrders.Add(order);
            }
            if (userOrders.Count == 0)
                return null;
            return userOrders;
        }

        public decimal GetTotalSales(Location location)
        {
            var orders = GetAllOrders();
            decimal sales = 0;
            foreach (Order order in orders)
            {
                if (order.locationId == location.locationID)
                {
                    sales += order.totalCost;
                }
            }
            return sales;
        }

        public User GetUser(string username)
        {
            var element = _db.Users.Where(a => a.Username.Contains(username)).FirstOrDefault();

            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
using PizzaBox.Domain;
using System.Linq;

namespace PizzaBox.Data
{
    public class UserRepository : IUserRepository, IOrderRepository, ILocationRepository
    {
        private readonly Model.PizzaContext _db;
        public UserRepository(Model.PizzaContext db)
        {
            _db = db;
        }

        public void AddLocation(Location location)
        {
            _db.Location.Add(Mapper.Map(location));
            Save();
        }

        public void AddOrder(PizzaBox.Domain.Order order)
        {
            _db.Orders.Add(Mapper.Map(order));
            Save();
        }

        public void AddUser(PizzaBox.Domain.User user)
        {
            _db.Users.Add(Mapper.Map(user));
            Save();
        }

        public decimal ComputeOrderCost(PizzaBox.Domain.Order order)
        {
            var list = order.pizzas;
            decimal cost = 0;
            foreach (PizzaBox.Domain.Pizza pizza in list)
            {
                cost += pizza.cost;
            }
            return cost;
        }

        public void DeleteLocation(int id)
        {
            _db.Location.Remove(_db.Location.Find(id));
            Save();
        }

        public void DeleteOrder(int id)
        {
            _db.Orders.Remove(_db.Orders.Find(id));
            Save();
        }

        public void DeleteUser(string username)
        {
            _db.Users.Remove(_db.Users.Find(username));
            Save();
        }

        public void EditLocation(Location location)
        {
            if (_db.Location.Find(location.locationID) != null)
            {
                _db.Location.Update(Mapper.Map(location));
                Save();
            }
        }

        public void EditOrder(Order order)
        {
            if (_db.Orders.Find(order.id) != null)
            {
                _db.Orders.Update(Mapper.Map(order));
                Save();
            }
        }

        public void EditUser(User user)
        {
            if (_db.Users.Find(user.Username) != null)
            {
                _db.Users.Update(Mapper.Map(user));
                Save();
            }
        }

        public IEnumerable<Location> GetAllLocations()
        {
            return _db.Location.Select(x => Mapper.Map(x));
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _db.Orders.Select(x => Mapper.Map(x));
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _db.Users.Select(x => Mapper.Map(x));
        }

        public Location GetLocation(int id)
        {
            var element = _db.Location.Where(a => a.Id == id).FirstOrDefault();

            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }

        public Order GetOrder(int id)
        {
            var element = _db.Orders.Where(a => a.Id == id).FirstOrDefault();

            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }

        public List<Order> GetOrdersByLocation(int locationid)
        {
            var orders = GetAllOrders();
            List<Order> locationOrders = new List<Order>();
            foreach (Order order in orders)
            {
                if (order.locationId == locationid)
                    locationOrders.Add(order);
            }
            if (locationOrders.Count == 0)
                return null;
            return locationOrders;
        }

        public List<Order> GetOrdersByUser(string username)
        {
            var orders = GetAllOrders();
            List<Order> userOrders = new List<Order>();
            foreach (Order order in orders)
            {
                if (order.userId == username)
                    userOrders.Add(order);
            }
            if (userOrders.Count == 0)
                return null;
            return userOrders;
        }

        public decimal GetTotalSales(Location location)
        {
            var orders = GetAllOrders();
            decimal sales = 0;
            foreach (Order order in orders)
            {
                if (order.locationId == location.locationID)
                {
                    sales += order.totalCost;
                }
            }
            return sales;
        }

        public User GetUser(string username)
        {
            var element = _db.Users.Where(a => a.Username.Contains(username)).FirstOrDefault();

            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
