using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Three_Brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double fatherFishingTime = double.Parse(Console.ReadLine());

            var cleaningTime = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother);
            Console.WriteLine($"Cleaning time: {cleaningTime *= 1.15:f2}");
            
            if (cleaningTime<=fatherFishingTime)
                Console.WriteLine
                    ($"Yes, there is a surprise - time left -> {Math.Floor(fatherFishingTime-cleaningTime)} hours.");
            else
                Console.WriteLine
                    ($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(cleaningTime-fatherFishingTime)} hours.");
        }
    }
}
