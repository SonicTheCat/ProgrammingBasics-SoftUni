using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Work_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int countOfWorkers= int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int hours = (countOfWorkers * 8) * workingDays;
            if (hours>=hoursNeeded)
            {
                Console.WriteLine($"{hours-hoursNeeded} hours left");
            }
            else
            {
                Console.WriteLine($"{hoursNeeded-hours} overtime");
                int penalties = (hoursNeeded - hours) * workingDays;
                Console.WriteLine($"Penalties: {penalties}");
            }
        }
    }
}
