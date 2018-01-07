using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double makarelPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            int shellsKG = int.Parse(Console.ReadLine());

            double palamudPrice = (makarelPrice * 1.60)*palamudKG;
            double safridPrice = (cacaPrice * 1.80)*safridKG;
            double shellsPrice = (double)shellsKG * 7.50;
            double totalPrice = palamudPrice + safridPrice + shellsPrice;

            Console.WriteLine($"{totalPrice:f2}");


        }
    }
}
