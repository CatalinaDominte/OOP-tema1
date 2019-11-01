using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class PizzaBase
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        
        public PizzaBase (string name, double cost )
        {
            this.Name = name;
            this.Cost = cost;
        }
        public void Print ()
        {
            Console.WriteLine($"Base: [{Name}] ($[{Cost}])");
        }
    }
}
