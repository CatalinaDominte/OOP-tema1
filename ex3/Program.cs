using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rate summerRate = new Rate()
            {
                Amount = 50,
                Currency = "Euro"

            };
            Rate winter = new Rate()
            {
                Amount = 40,
                Currency = "Euro"

            };
            Rate discount = new Rate()
            {
                Amount = 35,
                Currency = "Euro"

            };

            Room appartment1 = new Room()
            {
                Name = "Appartament 1",
                Rate = summerRate,
                Adults = 2,
                Children = 2

            };
            Room appartment2 = new Room()
            {
                Name = "Appartament 2",
                Rate = winter,
                Adults = 4,
                Children = 4

            };
            Room appartment3 = new Room()
            {
                Name = "Appartament 3",
                Rate = summerRate,
                Adults = 3,
                Children = 0

            };
            Room appartment4 = new Room()
            {
                Name = "Appartament 4",
                Rate = discount,
                Adults = 3,
                Children = 2

            };

            Hotel BlueLagoon = new Hotel()
            {
                Name = "Blue Lagoon",
                City = "Cebu",
                Stars = "4",
                Rooms = new List<Room>() { appartment1, appartment2, appartment4 }
            };

           

            Hotel SummerEco = new Hotel()
            {
                Name = "Summer Eco Lodge",
                City = "El Nido",
                Stars = "5",
                Rooms = new List<Room>() { appartment1, appartment2, appartment3, appartment4 }
            };
          

            Hotel Floraly = new Hotel()
            {
                Name = "Floraly",
                City = "Manila",
                Stars = "2",
               Rooms =new List<Room>() { appartment2, appartment4, }
            };

            App Aplication = new App()
            {
                HotelsList= new List<Hotel>() { Floraly, BlueLagoon }
            };

            Aplication.FindARoom(60);
            Aplication.AddHotel(SummerEco);
            Aplication.RemoveHotel(Floraly);
            //Aplication.PrintHotel();
            Floraly.PricesForNoRoom(3);
            
            summerRate.Print();
            appartment3.Print();
            Console.WriteLine(appartment2.GetPriceForDays(7));
            Floraly.Print();
            Console.ReadLine();
        }

    }
}
