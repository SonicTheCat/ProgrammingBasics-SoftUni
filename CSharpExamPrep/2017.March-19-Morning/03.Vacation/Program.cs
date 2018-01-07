using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            var price = budget*0.65;
            string location = "Alaska";
            string HotelOrCamp = "Camp";
            if (budget<=1000&&season=="winter")
            {             
                    price = budget * 0.45;
                    location = "Morocco";         
            }
            if (budget>1000&&budget<=3000)
            {
                HotelOrCamp = "Hut";
                price = budget * 0.80;
                if (season=="winter")
                {
                    price = budget * 0.60;
                    location = "Morocco";
                }
            }
            if (budget>3000)
            {
                HotelOrCamp = "Hotel";
                price = budget * 0.90;
                if (season=="winter")               
                    location = "Morocco";               
            }
            Console.WriteLine($"{location} - {HotelOrCamp} - {price:f2}");
        }
    }
}
