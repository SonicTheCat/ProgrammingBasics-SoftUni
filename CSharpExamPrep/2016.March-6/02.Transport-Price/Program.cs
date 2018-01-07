using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string DayOrNight = Console.ReadLine().ToLower();

            var price = 0.0;
            double Taxi = 0.79;
            double Bus = 0.09;
            double Train = 0.06;           
           

            if (distance<20)
            {
                price = Taxi * distance + 0.70;
                if (DayOrNight=="night")
                {
                    Taxi = 0.90;
                    price = Taxi * distance + 0.70;
                }
            }
            else if (distance>=20&&distance<100)
            {
                price = Bus * distance;
            }
            else 
            {
                price = Train * distance;
            }
            Console.WriteLine(price);

        }
    }
}
