using System;
using System.Collections.Generic;
using System.Text;
using PizzaBox.Data;

namespace PizzaBox.Domain
{
    public static class BusinessLogic
    {
        static decimal ComputeCost(Pizza p)
        {
            decimal cost = 0;

            if (p.Size == "small")
                cost += 5;
            else if (p.Size == "medium")
                cost += 8;
            else // p.Size == "large"
                cost += 12;

            if (p.Crust == "stuffed")
                cost += 2;

            if (p.PizzaToppings.Count > 2)
                cost += p.PizzaToppings.Count - 2;

            return cost;
        }

        static bool CheckOrderTime(PizzaBox.Data.Model.Orders o)
        {
            if (o.Ordertime < DateTime.Now)
                return true;
            return false;
        }
    }
}
