using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Pizza
    {
        public string Name { get; set; }
        public PizzaBase PizzaBase { get; set; }
        public PizzaTopping PizzaToppingg { get; set; }

        public List<PizzaTopping> PizzaToppings { get; set; } = new List<PizzaTopping>() { };
        

        public void CalculateTotalCost()
        {
            double topping = 0;
            foreach (var cost in PizzaToppings)
            {
                topping = topping + cost.Cost;
            }
            Console.WriteLine($"Total Cost: $[{this.PizzaBase.Cost + topping}]");
        }
        public void AddTopping(PizzaTopping PizzaTopping)
        {
            for (int i = 0; i < 1; i++)
            {
                PizzaToppings.Add(PizzaTopping);
            }
        }


}
}