using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysBaking = int.Parse(Console.ReadLine());
            var totalLiters = 0d;
            var degrees = 0d;
            for (int i = 0; i < daysBaking; i++)
            {
                double litersPerDay = double.Parse(Console.ReadLine());
                double degreesPerDay = double.Parse(Console.ReadLine());
                totalLiters += litersPerDay;
                degrees += litersPerDay*degreesPerDay;
            }
            degrees = degrees / totalLiters;
            Console.WriteLine($"Liter: {totalLiters:f2}");
            Console.WriteLine($"Degrees: {degrees:f2}");

            if (degrees<38)
                Console.WriteLine($"Not good, you should baking!");
            else if (degrees>=38&&degrees<=42)
                Console.WriteLine("Super!");
            else
                Console.WriteLine("Dilution with distilled water!");
        }
    }
}
