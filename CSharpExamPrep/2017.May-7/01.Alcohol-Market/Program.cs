using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhisky = double.Parse(Console.ReadLine());
            double litersBeer = double.Parse(Console.ReadLine());
            double litersWine = double.Parse(Console.ReadLine());
            double litersRakia = double.Parse(Console.ReadLine());
            double litersWhisky = double.Parse(Console.ReadLine());

            double whisky = priceWhisky * litersWhisky;
            double priceRakia = (priceWhisky * 0.50);
            double priceWine = priceRakia * 0.60;
            double priceBeer = priceRakia * 0.20;

            Console.WriteLine($"{whisky+(priceRakia*litersRakia)+(priceWine*litersWine)+(priceBeer*litersBeer):f2}");
        }
    }
}
