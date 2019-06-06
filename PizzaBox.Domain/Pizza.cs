using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public enum Crust
    {
        original,
        thin,
        stuffed
    };
    public enum Size
    {
        small,
        medium,
        large
    };
    public enum Topping
    {
        cheese,
        pepperoni,
        sausage,
        ham,
        chicken,
        beef,
        pineapple,
        peppers,
        onions,
        jalapenos,
        mushrooms
    };

    public enum Specialty
    {
        supreme,
        meatlovers,
        veggie,
        hawaiian
    };

    public class Pizza
    {
        public string crust { get; set; }
        public string size { get; set; }
        public decimal cost { get; set; }
        public List<string> toppings = new List<string>();
        public int orderId { get;  set; }
        public int id { get; set; }
        

        public Pizza()
        {
            crust = "original";
            size = "medium";
            cost = 5.0M;
            toppings.Add("cheese");
            toppings.Add("pepperoni");
        }

        public Pizza(string c, string s, List<string> tops)
        {
            crust = c;
            size = s;
            if (tops.Count > 5)
            {
                Console.WriteLine("Max number of toppings exceeded; will only add first 5");
                for (int i = 0; i < 5; ++i)
                    toppings.Add(tops[i]);
            }
            else
            {
                foreach (string t in tops)
                    toppings.Add(t);
            }
            ComputeCost();
        }

        public Pizza(string c, string s, Specialty spec)  //for creating a specialty pizza
        {
            crust = c;
            size = s;
            if (spec == Specialty.supreme)
            {
                toppings.Add("cheese");
                toppings.Add("pepperoni");
                toppings.Add("peppers");
                toppings.Add("onions");
                toppings.Add("mushrooms");
            }
            if (spec == Specialty.meatlovers)
            {
                toppings.Add("cheese");
                toppings.Add("pepperoni");
                toppings.Add("sausage");
                toppings.Add("beef");
                toppings.Add("ham");
            }
            if (spec == Specialty.veggie)
            {
                toppings.Add("cheese");
                toppings.Add("peppers");
                toppings.Add("onions");
                toppings.Add("mushrooms");
            }
            if (spec == Specialty.hawaiian)
            {
                toppings.Add("cheese");
                toppings.Add("pepperoni");
                toppings.Add("ham");
                toppings.Add("pineapple");
            }
            ComputeCost();
        }

        /* Cost is calculated as follows:
         * Base price - 5 small, 8 medium, 12 large
         * Stuffed crust - add 2
         * First two toppings included. Additional toppings - add 1 each (max 5 toppings total)
         */
        public void ComputeCost()
        {
            decimal c = 0;
            if (size == "small")
                c += 5;
            else if (size == "medium")
                c += 8;
            else
                c += 12;
            if (crust == "stuffed")
                c += 2;
            if (toppings.Count > 2)
                c += (toppings.Count - 2);
            cost = c;
        }

        public void setOrderId(int id)
        {
            orderId = id;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Crust: {crust}");
            Console.WriteLine($"Size: {size}");
            Console.WriteLine("Toppings: ");
            foreach (string t in toppings)
                Console.WriteLine($"\t{t}");
            Console.WriteLine($"Cost: ${cost}");
        }
    }
}
