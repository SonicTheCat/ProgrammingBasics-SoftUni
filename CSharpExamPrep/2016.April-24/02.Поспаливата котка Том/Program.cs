using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            double dayOffDays = double.Parse(Console.ReadLine());
            double workingDays = (365 - dayOffDays) * 63;
            dayOffDays = dayOffDays * 127;         
            double totalPlay = dayOffDays + workingDays;
            if (totalPlay>30000)
            {
                double hours = (totalPlay - 30000) / 60;
                double minutes = (totalPlay - 30000) % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                double hours = (30000 - totalPlay) / 60;
                double minutes = (30000 - totalPlay) % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }

        }
    }
}
