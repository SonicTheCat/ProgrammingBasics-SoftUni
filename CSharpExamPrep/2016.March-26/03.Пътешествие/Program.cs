using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string campOrHotel = "Camp";
            string destination = "Bulgaria";
            double fromBudget = budget * 0.30;

            if (budget<=100&&season=="winter")
            {
                fromBudget = budget * 0.70;
                campOrHotel = "Hotel";
            }
            else if (budget<=1000&&budget>100)
            {
                destination= "Balkans";
                if (season=="summer")
                {
                    fromBudget = budget * 0.40;
                }
                else
                {
                    campOrHotel = "Hotel";
                    fromBudget = budget * 0.80;
                }
            }
            else if (budget>1000)
            {
                destination = "Europe";
                fromBudget = budget * 0.90;
                campOrHotel = "Hotel";
            }
          
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campOrHotel} - {fromBudget:f2}");

        }
    }
}
