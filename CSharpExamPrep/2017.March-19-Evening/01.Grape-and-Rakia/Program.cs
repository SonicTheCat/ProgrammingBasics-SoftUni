using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaGrape = double.Parse(Console.ReadLine());
            double grapeSqrMeeter = double.Parse(Console.ReadLine());
            double  trownAway = double.Parse(Console.ReadLine());

            var totalGrape = (areaGrape * grapeSqrMeeter) - trownAway;
            var rakiaGrape = totalGrape * 0.45;
            var forSale = totalGrape * 0.55;
            var totalRakia = (rakiaGrape / 7.5)*9.80;        
            forSale = forSale * 1.50;
            Console.WriteLine($"{totalRakia:f2}");
            Console.WriteLine($"{forSale:f2}");
        }
    }
}
