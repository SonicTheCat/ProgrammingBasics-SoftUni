using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double meetersHarves = double.Parse(Console.ReadLine());
            double grapeForOneSquareMeeter = double.Parse(Console.ReadLine());
            double litresWineNeeded = double.Parse(Console.ReadLine());
            double countOfWorkers = double.Parse(Console.ReadLine());

           
            double totalGrape = meetersHarves * grapeForOneSquareMeeter;
            double harvestForWine = totalGrape * 0.40;
            double totalLitres = harvestForWine / 2.5;
            var result = Math.Abs(totalLitres - litresWineNeeded);


            if (totalLitres<litresWineNeeded)
            {
              
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(result)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalLitres)} liters.");
                Console.WriteLine($"{Math.Ceiling(result)} liters left -> {Math.Ceiling(result/countOfWorkers)} liters per person.");
            }
        }
    }
}
