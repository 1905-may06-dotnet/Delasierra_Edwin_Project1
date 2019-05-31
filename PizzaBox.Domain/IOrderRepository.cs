using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        void DeleteOrder(int id);
        void EditOrder(Order order);
        IEnumerable<Order> GetAllOrders();
        List<Order> GetOrdersByUser(string username);
        List<Order> GetOrdersByLocation(int locationid);
        Order GetOrder(int id);
    }
}
