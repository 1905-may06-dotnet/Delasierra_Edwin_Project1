using System;
using System.Collections.Generic;
using System.Text;
using PizzaBox.Domain;
using System.Linq;

namespace PizzaBox.Data
{
    public class UserRepository : IUserRepository, IOrderRepository
    {
        private readonly Model.PizzaContext _db;
        public UserRepository(Model.PizzaContext db)
        {
            _db = db;
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

        public IEnumerable<Order> GetAllOrders()
        {
            return _db.Orders.Select(x => Mapper.Map(x));
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _db.Users.Select(x => Mapper.Map(x));
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
