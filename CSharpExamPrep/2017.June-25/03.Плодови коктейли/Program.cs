using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Плодови_коктейли
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string coktailSize = Console.ReadLine();
            int countOfDrinks = int.Parse(Console.ReadLine());
            double pricePerLiter = 56;

            if (coktailSize=="big") pricePerLiter = 28.70;

            if (fruit=="mango")
            {
                pricePerLiter = 36.66;
                if (coktailSize == "big")
                {
                    pricePerLiter = 19.60;
                }
            }
            if (fruit == "pineapple")
            {
                pricePerLiter = 42.10;
                if (coktailSize == "big")
                {
                    pricePerLiter = 24.80;
                }
            }
            if (fruit == "raspberry")
            {
                pricePerLiter = 20;
                if (coktailSize == "big")
                {
                    pricePerLiter = 15.20;
                }
            }
            var pricePerDrink = coktailSize == "big" ? pricePerLiter * 5 : pricePerLiter * 2;
            var price = pricePerDrink * countOfDrinks;
            if (price>1000)
                price = price * 0.50;
            else if (price>=400&&price<=1000)
                price = price * 0.85;
            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
