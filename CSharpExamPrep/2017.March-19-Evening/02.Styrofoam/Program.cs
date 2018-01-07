using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseSqrtMeeters = double.Parse(Console.ReadLine());
            double countOfWindows = double.Parse(Console.ReadLine());
            double foamInOneBox = double.Parse(Console.ReadLine());
            double priceFoamOneBox = double.Parse(Console.ReadLine());

            houseSqrtMeeters = (houseSqrtMeeters - (countOfWindows * 2.4)) * 1.10;
            houseSqrtMeeters = houseSqrtMeeters / foamInOneBox;
            var price = Math.Ceiling(houseSqrtMeeters) * priceFoamOneBox;
            if (price <= budget)
            {
                Console.WriteLine($"Spent: {price:f2}");
                Console.WriteLine($"Left: {budget - price:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {price - budget:f2}");
            }
        }
    }
}
