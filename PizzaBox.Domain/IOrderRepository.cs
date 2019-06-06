<<<<<<< HEAD
﻿using System;
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
        decimal ComputeOrderCost(Order order);
        void Save();
    }
}
=======
﻿using System;
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
        decimal ComputeOrderCost(Order order);
        void Save();
    }
}
>>>>>>> 45643b0a3b5621839fd67967e451c1814b205e27
