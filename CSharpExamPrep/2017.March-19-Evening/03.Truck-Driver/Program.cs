using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double kmPerMonth = double.Parse(Console.ReadLine());
            var sallary = kmPerMonth * 0.75 ;

            if (kmPerMonth>5000&&kmPerMonth<=10000)
            {
                sallary = kmPerMonth * 0.95;
            }
            if (season=="summer")
            {
                if (kmPerMonth<=5000)
                {
                    sallary = kmPerMonth*0.90;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    sallary = kmPerMonth * 1.10;
                }
            }
            else if (season == "winter")
            {
                if (kmPerMonth <= 5000)
                {
                    sallary = kmPerMonth * 1.05;
                }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                {
                    sallary = kmPerMonth * 1.25;
                }
            }
            if (kmPerMonth>10000&&kmPerMonth<=20000)
            {
                sallary = kmPerMonth * 1.45;
            }
            var totalSallary = (sallary * 4) * 0.90;
            Console.WriteLine($"{totalSallary:f2}");
        }
    }
}
