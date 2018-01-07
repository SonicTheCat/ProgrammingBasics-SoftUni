using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pipes_in_a_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLitresPool = int.Parse(Console.ReadLine());
            double firstPipeDebit = double.Parse(Console.ReadLine());
            double secondPipeDebit = double.Parse(Console.ReadLine());
            double workerMissing = double.Parse(Console.ReadLine());

            double hoursFirstPipe = firstPipeDebit * workerMissing;
            double hoursSecondPipe = secondPipeDebit * workerMissing;
            double bothPipes = hoursFirstPipe + hoursSecondPipe;
            if (bothPipes<=totalLitresPool)
            {
                int percentageFirstPipe = (int)(hoursFirstPipe / bothPipes * 100);
                int percentageSecondPipe = (int)(hoursSecondPipe/ bothPipes * 100);
                int percentageFull = (int)(bothPipes / totalLitresPool * 100);
                Console.WriteLine
               ($"The pool is {percentageFull}% full. Pipe 1: {percentageFirstPipe}%. Pipe 2: {percentageSecondPipe}%.");
            }
            else
            {
                double overFlow = (bothPipes - totalLitresPool);
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",workerMissing, overFlow);
                // защо трябва да е :f1 на ред 33 ? Защо ми дава грешка, когато го няма? 
            }
        }
    }
}
