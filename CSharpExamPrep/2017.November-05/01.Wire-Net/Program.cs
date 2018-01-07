using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenthArea = double.Parse(Console.ReadLine());
            double widthArea = double.Parse(Console.ReadLine());
            double heightNet = double.Parse(Console.ReadLine());
            double priceNetMeeter = double.Parse(Console.ReadLine());
            double netKgMeeter = double.Parse(Console.ReadLine());

            var neededNet = 2 * lenthArea + 2 * widthArea;
            var price = neededNet * priceNetMeeter;
            var netArea = neededNet * heightNet;
            var netKG = netArea * netKgMeeter;

            Console.WriteLine($"{neededNet}");
            Console.WriteLine($"{price:F2}");
            Console.WriteLine($"{netKG:F3}");
        }
    }
}
