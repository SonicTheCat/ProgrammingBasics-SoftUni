using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Final_Competitions
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfDancers = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string country = Console.ReadLine().ToLower();

            var price = (points*countOfDancers)*0.95;
            if (season=="winter") price = (points * countOfDancers) * 0.92;

            if (country=="abroad")
            {
                price = (points * countOfDancers) * 1.50;
                price = price * 0.90;
                if (season=="winter")
                {
                    price = (points * countOfDancers) * 1.50;
                    price = price * 0.85;
                }
            }
            var charity = price * 0.75;
            price = (price - charity) / countOfDancers;
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {price:f2}");
        }
    }
}
