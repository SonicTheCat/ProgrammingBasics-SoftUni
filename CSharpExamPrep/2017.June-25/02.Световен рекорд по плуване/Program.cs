using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Световен_рекорд_по_плуване
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsForOneMeeter = double.Parse(Console.ReadLine());

            double ivansRecord = distance * secondsForOneMeeter;
            double waterStopage = Math.Floor(distance / 15) * 12.5;          
            ivansRecord = ivansRecord + waterStopage;
            if (ivansRecord>=worldRecord)
            {
                Console.WriteLine($"No, he failed! He was {ivansRecord-worldRecord:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansRecord:f2} seconds.");
            }
        }
    }
}
