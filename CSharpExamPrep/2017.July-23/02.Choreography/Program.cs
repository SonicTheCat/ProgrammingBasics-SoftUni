using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfSteps = double.Parse(Console.ReadLine()); 
            double countOfDancers = double.Parse(Console.ReadLine()); 
            double daysPractice = double.Parse(Console.ReadLine());

            double stepsPerDay = (countOfSteps / daysPractice) / countOfSteps*100;
            stepsPerDay = Math.Ceiling(stepsPerDay);
            double stepsPerPerson = stepsPerDay / countOfDancers;

            if (stepsPerDay<=13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerPerson:f2}%.");
            }
            else
            {
                Console.WriteLine
                    ($"No, They will not succeed in that goal! Required {stepsPerPerson:f2}% steps to be learned per day.");
            }
        }
    }
}
