using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Деление_без_остатък
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1=0;
            int p2=0;
            int p3=0;

            for (int i = 1; i <=n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    p1++;
                }
                if (num%3==0)
                {
                    p2++;
                }
                if (num%4==0)
                {
                    p3++;
                }
            }
            double percentageP1 = (double)p1 / n * 100;
            double percentageP2 = (double)p2 / n * 100;
            double percentageP3 = (double)p3 / n * 100;
            Console.WriteLine($"{percentageP1:f2}%");
            Console.WriteLine($"{percentageP2:f2}%");
            Console.WriteLine($"{percentageP3:f2}%");
            
        }
    }
}
