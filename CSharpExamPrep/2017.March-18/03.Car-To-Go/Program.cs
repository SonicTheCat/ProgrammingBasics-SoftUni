using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string klass = "Economy class";
            string car = "Cabrio";
            double price = budget * 0.35;          

            if (budget<=100&&season=="winter")
            {
                price = budget * 0.65;
                car = "Jeep";
            }
            else if (budget>100&&budget<=500)
            {
                klass = "Compact class";
                if (season=="summer")
                {
                    price = budget*0.45;
                }
                else
                {
                    price = budget * 0.80;
                    car = "Jeep";
                }
            }
            else if (budget>500)
            {
                klass = "Luxury class";
                price = budget * 0.90;
                car = "Jeep";
            }
            Console.WriteLine(klass);
            Console.WriteLine($"{car} - {price:f2}");       
        }
    }
}
