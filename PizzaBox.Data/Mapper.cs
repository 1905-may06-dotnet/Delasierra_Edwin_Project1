using System;
using System.Collections.Generic;
using System.Text;
using PizzaBox.Domain;

namespace PizzaBox.Data
{
    public static class Mapper
    {
        public static PizzaBox.Data.Model.Users Map(PizzaBox.Domain.User user)
        {
            PizzaBox.Data.Model.Users dataUser = new Model.Users();
            dataUser.Username = user.Username;
            dataUser.Password = user.Password;
            return dataUser;
        }
        public static PizzaBox.Domain.User Map(PizzaBox.Data.Model.Users user) => new PizzaBox.Domain.User
        {
            Username = user.Username,
            Password = user.Password
        };

        public static PizzaBox.Data.Model.Orders Map(PizzaBox.Domain.Order order)
        {
            PizzaBox.Data.Model.Orders dataOrder = new Model.Orders();
            dataOrder.Id = order.id;
            dataOrder.Locationid = order.locationId;
            dataOrder.Ordertime = order.time;
            dataOrder.User.Username = order.userId;
            dataOrder.Totalcost = order.totalCost;
            return dataOrder;
        }
        public static PizzaBox.Domain.Order Map(PizzaBox.Data.Model.Orders order) => new PizzaBox.Domain.Order
        {
            id = order.Id,
            locationId = order.Locationid,
            time = order.Ordertime,
            userId = order.User.Username,
            totalCost = order.Totalcost
        };
    }
}
