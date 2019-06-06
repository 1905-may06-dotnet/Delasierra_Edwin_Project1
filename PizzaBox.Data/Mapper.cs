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

        public static PizzaBox.Data.Model.Location Map(PizzaBox.Domain.Location location)
        {
            PizzaBox.Data.Model.Location dataLocation = new Model.Location();
            dataLocation.Id = location.locationID;
            dataLocation.Name = location.name;
            dataLocation.Street1 = location.street1;
            dataLocation.Street2 = location.street2;
            dataLocation.City = location.city;
            dataLocation.State = location.state;
            dataLocation.Zipcode = location.zipcode;
            return dataLocation;
        }
        public static PizzaBox.Domain.Location Map(PizzaBox.Data.Model.Location location) => new PizzaBox.Domain.Location
        {
            locationID = location.Id,
            name = location.Name,
            street1 = location.Street1,
            street2 = location.Street2,
            city = location.City,
            state = location.State,
            zipcode = location.Zipcode
        };

        public static List<PizzaBox.Data.Model.PizzaToppings> MapToppings(PizzaBox.Domain.Pizza pizza)
        {
            var toplist = pizza.toppings;
            List<PizzaBox.Data.Model.PizzaToppings> ptops = new List<PizzaBox.Data.Model.PizzaToppings>();
            foreach (string t in toplist)
            {
                PizzaBox.Data.Model.PizzaToppings pt = new Model.PizzaToppings();
                pt.Pizzaid = pizza.id;
                if (t == "mushrooms")
                    pt.Toppingid = 10;
                else if (t == "pepperoni")
                    pt.Toppingid = 1;
                else if (t == "sausage")
                    pt.Toppingid = 2;
                else if (t == "ham")
                    pt.Toppingid = 3;
                else if (t == "chicken")
                    pt.Toppingid = 4;
                else if (t == "beef")
                    pt.Toppingid = 5;
                else if (t == "pineapple")
                    pt.Toppingid = 6;
                else if (t == "peppers")
                    pt.Toppingid = 7;
                else if (t == "onions")
                    pt.Toppingid = 8;
                else if (t == "jalapenos")
                    pt.Toppingid = 9;
                else // cheese
                    pt.Toppingid = 0;

                ptops.Add(pt);
            }
            return ptops;
        }

        /*public static List<string> MapToppings(PizzaBox.Data.Model.Pizza pizzatops)
        {
            List<string> tops = new List<string>();
            pizzatops.PizzaToppings
        }*/

        public static PizzaBox.Data.Model.Pizza Map(PizzaBox.Domain.Pizza pizza)
        {
            PizzaBox.Data.Model.Pizza dataPizza = new Model.Pizza();
            pizza.ComputeCost();
            dataPizza.Id = pizza.id;
            dataPizza.Crust = pizza.crust.ToString();
            dataPizza.Size = pizza.size.ToString();
            dataPizza.Cost = pizza.cost;
            return dataPizza;
        }
        public static PizzaBox.Domain.Pizza Map(PizzaBox.Data.Model.Pizza pizza) => new PizzaBox.Domain.Pizza
        {
            id = pizza.Id,
            crust = pizza.Crust,
            size = pizza.Size,
            cost = pizza.Cost
        };
    }
}
