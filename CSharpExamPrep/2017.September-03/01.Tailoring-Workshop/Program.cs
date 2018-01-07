using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTables = int.Parse(Console.ReadLine());
            double lenthTables = double.Parse(Console.ReadLine());
            double widthTables = double.Parse(Console.ReadLine());

            var coverSize = countOfTables*(lenthTables+2*0.30) * (widthTables+ 2 * 0.30);
            var squareSize = countOfTables*(lenthTables/2)*(lenthTables/2);
            var priceInUSD = coverSize * 7 + squareSize * 9;
            var priceInLeva = priceInUSD * 1.85;
            Console.WriteLine($"{priceInUSD:f2} USD");
            Console.WriteLine($"{priceInLeva:f2} BGN");
        }
    }
}
