using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.odd_even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            if (evenSum==oddSum)
            {
                Console.WriteLine($"Yes ");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                var diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No ");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
