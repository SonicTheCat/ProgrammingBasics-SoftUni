using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double countOfPuzzles = double.Parse(Console.ReadLine());
            double countOfDolls = double.Parse(Console.ReadLine());
            double countOfTeddyBears = double.Parse(Console.ReadLine());
            double countOfMinions = double.Parse(Console.ReadLine());
            double countOfTrucks = double.Parse(Console.ReadLine());
            var totalAmount = countOfPuzzles + countOfDolls + countOfTeddyBears + countOfMinions + countOfTrucks;

            double pricePuzzles = countOfPuzzles * 2.60;
            double priceDolls = countOfDolls* 3;
            double priceTeddyBears = countOfTeddyBears*4.10;
            double priceMinions = countOfMinions*8.20;
            double priceTrucks = countOfTrucks*2;
            var totalPrice = pricePuzzles + priceDolls + priceTeddyBears + priceMinions + priceTrucks;
            if (totalAmount>=50)            
                totalPrice = totalPrice * 0.75;
            totalPrice = totalPrice * 0.90;

            if (totalPrice>=tripPrice)
                Console.WriteLine($"Yes! {totalPrice-tripPrice:f2} lv left.");
            else
                Console.WriteLine($"Not enough money! {tripPrice-totalPrice:f2} lv needed.");
        }
    }
}
