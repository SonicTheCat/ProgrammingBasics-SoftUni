using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Energy_Lost
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingDays = int.Parse(Console.ReadLine());
            int countOFDancers = int.Parse(Console.ReadLine());
            var EvenDaysEvenHours = 0;
            var oddDaysEvenHours = 0;
            var EvenDaysOddHours = 0;
            var oddDaysoddHours = 0;
            for (int i = 1; i <=trainingDays; i++)
            {
                int hoursTraining = int.Parse(Console.ReadLine());
                if (i%2==0&&hoursTraining%2==0)
                {
                    EvenDaysEvenHours += countOFDancers * 68;
                }
                if (i % 2 != 0 && hoursTraining % 2 == 0)
                {
                    oddDaysEvenHours += countOFDancers * 49;
                }
                if (i % 2 == 0 && hoursTraining % 2 != 0)
                {
                    EvenDaysOddHours += countOFDancers * 65;
                }
                if (i % 2 != 0 && hoursTraining % 2 != 0)
                {
                    oddDaysoddHours += countOFDancers * 30;
                }
            }
            double totalEnergy = 100 * countOFDancers * trainingDays;
            totalEnergy = totalEnergy - (EvenDaysEvenHours + oddDaysEvenHours + EvenDaysOddHours + oddDaysoddHours);
            double energyLeft = totalEnergy / countOFDancers / trainingDays;

            if (energyLeft>=50)
            {
                Console.WriteLine($"They feel good! Energy left: {energyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {energyLeft:f2}");

            }
        }
    }
}
