using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cups
{
    class Program
    {
        static void Main(string[] args)
        {          
            int cupsToBeMade = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            var timeWorking = (countOfWorkers * 8) * workingDays;
            var countOfCups = timeWorking / 5;
            if (countOfCups < cupsToBeMade)
            {
                var result = cupsToBeMade - countOfCups;
                Console.WriteLine($"Losses: {result * 4.2:f2}");
            }
            else
            {
                var result = countOfCups - cupsToBeMade;
                Console.WriteLine($"{result * 4.2:f2} extra money");
            }
        }
    }
}
