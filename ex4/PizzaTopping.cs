using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class PizzaTopping
    {
        public string Nam { get; set; }
        public double Cost { get; set; }
        public PizzaTopping(string name, double cost)
        {
            this.Nam = name;
            this.Cost = cost;
        }
        public void Print()
        {
            Console.WriteLine($"{Nam} ($[{Cost}])");
        }

        
    }
}
