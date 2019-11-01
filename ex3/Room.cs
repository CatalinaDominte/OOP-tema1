using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Room
    {
        public string Name { get; set; }
        public Rate Rate  { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }

        //public int Days { get; set; }

       

        public decimal GetPriceForDays(int numberOfDays)
        {
            return Rate.Amount * numberOfDays;
        }
        public void Print()
        {
            Console.WriteLine($"Camera:{this.Name}, Cost: {Rate.Amount} {Rate.Currency}, Capacitate: {Adults} adulti, {Children} copii");
        }



    }
}
