using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {         
            double priceKgVegitables = double.Parse(Console.ReadLine());
            double priceKgFruits = double.Parse(Console.ReadLine());
            double vegitablesForSale = double.Parse(Console.ReadLine());
            double fruitsForSale = double.Parse(Console.ReadLine());

            double totalInCome = ((priceKgVegitables * vegitablesForSale) + (priceKgFruits * fruitsForSale)) / 1.94;
            Console.WriteLine(totalInCome);



        }
    }
}
