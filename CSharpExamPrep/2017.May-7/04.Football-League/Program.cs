using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double numberOfFans = double.Parse(Console.ReadLine());
            var sectorA = 0d;
            var sectorB = 0d;
            var sectorV = 0d;
            var sectorG = 0d;

            for (int i = 0; i < numberOfFans; i++)
            {
                string sector = Console.ReadLine();
                if (sector=="A")
                    sectorA++;
                else if(sector=="B")
                    sectorB++;
                else if (sector == "V")
                    sectorV++;
                else if (sector == "G")
                    sectorG++;
            }
            Console.WriteLine($"{sectorA/numberOfFans * 100:f2}%");
            Console.WriteLine($"{sectorB/numberOfFans * 100:f2}%");
            Console.WriteLine($"{sectorV/numberOfFans * 100:f2}%");
            Console.WriteLine($"{sectorG/numberOfFans * 100:f2}%");
            Console.WriteLine($"{numberOfFans/stadiumCapacity*100:f2}%");
        }
    }
}
