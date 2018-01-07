using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Парична_награда
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectParts = int.Parse(Console.ReadLine());
            double priceForOnePoint = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <=projectParts; i++)
            {
                double points = double.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sum += points * 2;
                }
                else
                {
                    sum += points;
                }
            }
            Console.WriteLine($"The project prize was {sum*priceForOnePoint:f2} lv.");
        }
    }
}
