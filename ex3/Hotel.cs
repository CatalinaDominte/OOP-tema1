using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Stars { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
       

        public void PricesForNoRoom(int no)
       {
            Console.WriteLine($"Pretul camerelor pe {no} zile este: ");
            decimal price = 0;
            foreach (var item in Rooms)
            {
                price= item.Rate.Amount * no;
                Console.WriteLine($"{item.Name} - {price} ({item.Rate.Currency})");
            }
            
        }
        public void Print()
        {
            Console.WriteLine($"Hotelul: {this.Name}, din orasul: {this.City}, are {this.Stars} stele. Camerele disponibile sunt urmatoarele:");

            foreach (var room in Rooms)
            {
                Console.WriteLine(room.Name);
            }
        }
    }

}
