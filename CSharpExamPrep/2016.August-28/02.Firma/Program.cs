using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firma
{
    class Program
    {
        static void Main(string[] args)
        {          
            int hoursNeeded = int.Parse(Console.ReadLine());
            double daysToDo = double.Parse(Console.ReadLine());
            int workersOverTime = int.Parse(Console.ReadLine());

            double cantWork = daysToDo * 0.90;
            double workinHours = cantWork * 8;
            double overTime = (workersOverTime * daysToDo) * 2;
            double total = workinHours + overTime;
            total = Math.Floor(total);

            if (total>= hoursNeeded)
            {
                double result = total - hoursNeeded;
                Console.WriteLine($"Yes!{result} hours left.");
            }
            else
            {
                double result = hoursNeeded - total;
                Console.WriteLine($"Not enough time!{result} hours needed.");
            }

        }
    }
}
