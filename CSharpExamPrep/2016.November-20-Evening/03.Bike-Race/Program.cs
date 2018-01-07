using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string roads = Console.ReadLine();

            double taxJuniors = 5.50;
            double taxSeniors = 7;

            if (roads=="cross-country")
            {
                 taxJuniors = 8;
                 taxSeniors = 9.50;
                if (juniors+seniors>=50)
                {
                    taxJuniors = taxJuniors * 0.75;
                    taxSeniors = taxSeniors * 0.75;
                }
            }
            else if(roads=="downhill")
            {
                taxJuniors = 12.25;
                taxSeniors = 13.75;
            }
            else if (roads == "road")
            {
                taxJuniors = 20;
                taxSeniors = 21.50;
            }
            var cleanInCome = ((taxSeniors * seniors) + (taxJuniors * juniors)) * 0.95;
            Console.WriteLine($"{cleanInCome:f2}");
        }
    }
}
