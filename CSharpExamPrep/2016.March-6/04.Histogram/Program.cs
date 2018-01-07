using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double num = 0;

            for (double i = 0; i < n; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (num<200)
                {
                    p1++;
                }
                else if (num>=200&&num<=399)
                {
                    p2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else if (num >=800)
                {
                    p5++;
                }
            }
            double percentageP1 = (p1 / n) * 100;
            double percentageP2 = (p2 / n) * 100;
            double percentageP3 = (p3 / n) * 100;
            double percentageP4 = (p4 / n) * 100;
            double percentageP5 = (p5 / n) * 100;
            Console.WriteLine($"{percentageP1:F2}%");
            Console.WriteLine($"{percentageP2:F2}%");
            Console.WriteLine($"{percentageP3:F2}%");
            Console.WriteLine($"{percentageP4:F2}%");
            Console.WriteLine($"{percentageP5:F2}%");
        }
    }
}
