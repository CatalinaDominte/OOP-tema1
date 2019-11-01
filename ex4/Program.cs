using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBase Regular = new PizzaBase("Regular", 2);
            PizzaBase Thick = new PizzaBase("Thick", 1.8);
            PizzaBase Italian = new PizzaBase("Italian", 1.5*Regular.Cost);

            PizzaTopping salami = new PizzaTopping("SALAMI", 1.55);
            PizzaTopping chorizo = new PizzaTopping("CHORIZO", 1.75);
            PizzaTopping prosciuto = new PizzaTopping("PROSCIUTO", 2.20);
            PizzaTopping mushrooms = new PizzaTopping("Mushrooms", 0.55);
            PizzaTopping tomato = new PizzaTopping("Tomato", 0.50);
            PizzaTopping olives = new PizzaTopping("Olives", 0.85);
            PizzaTopping pepper = new PizzaTopping("Pepper", 0.25);
            PizzaTopping rucola = new PizzaTopping("Rucola", 0.90);
            PizzaTopping onions = new PizzaTopping("Onions", 0.25);
            PizzaTopping garlic = new PizzaTopping("Garlic", 0.15);


            Pizza roma = new Pizza()
            {
                Name = "Roma",
                PizzaBase = Italian,
                PizzaToppings = new List<PizzaTopping>() { salami, mushrooms, tomato, olives },
                
        };

            Pizza napoli = new Pizza()
            {
                Name = "Napoli",
                PizzaBase = Thick,
                PizzaToppings = new List<PizzaTopping>() { prosciuto, pepper, tomato, rucola, olives, onions },
            };

            Pizza carnivore = new Pizza()
            {
                Name = "Carnivore",
                PizzaBase = Regular,
                PizzaToppings = new List<PizzaTopping>() { prosciuto, pepper, tomato, rucola, olives, onions, garlic },

            };

            roma.AddTopping(prosciuto);
            Console.WriteLine($"Pizza:[{roma.Name}]");
            roma.PizzaBase.Print();
            Console.WriteLine("Toppings:");
            foreach (var item in roma.PizzaToppings)
            {
                item.Print();
            }
            roma.CalculateTotalCost();
            Console.WriteLine("--------------------------------------------");

            carnivore.AddTopping(rucola);
            carnivore.AddTopping(chorizo);
            Console.WriteLine($"Pizza:[{carnivore.Name}]");
            carnivore.PizzaBase.Print();
            Console.WriteLine("Toppings:");
            foreach (var item in carnivore.PizzaToppings)
            {
                item.Print();
            }
            carnivore.CalculateTotalCost();

            Console.WriteLine("--------------------------------------------");

            napoli.AddTopping(rucola);
            Console.WriteLine($"Pizza:[{napoli.Name}]");
            napoli.PizzaBase.Print();
            Console.WriteLine("Toppings:");
            foreach (var item in carnivore.PizzaToppings)
            {
                item.Print();
            }
            napoli.CalculateTotalCost();

            Console.ReadLine();
        }
    }
}
