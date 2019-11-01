using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class App
    {
        public List<Hotel> HotelsList { get; set; } = new List<Hotel>();

        public void FindARoom(int price)
        {
            bool x = true;
            Console.WriteLine($"The rooms with the price lower than {price} (Euro): ");
            foreach (var item in HotelsList)
            {
                foreach (var room in item.Rooms)
                {
                    if (price >= room.Rate.Amount)
                    {
                        Console.WriteLine($"\n {item.Name}, {room.Name} - {room.Rate.Amount} ({room.Rate.Currency}) ");
                    }
                    else
                    {
                        x = false;
                    }
                }
            }
            if (x==false)
            {
                Console.WriteLine($"There are no rooms with the price lower than {price} ($): ");
            }
        }
        
        public void AddHotel(Hotel hotel)
        {
            for (int i = 0; i < 1; i++)
            {
                HotelsList.Add(hotel);
            }
        }
        public void RemoveHotel(Hotel hotel)
        {
            for (int i = 0; i < 1; i++)
            {
                HotelsList.Remove(hotel);
            }
        }

        public void PrintHotel()
        {
            foreach (var hotel in HotelsList)
            {
                Console.WriteLine(hotel.Name);
            }
        }
        

    }
}
