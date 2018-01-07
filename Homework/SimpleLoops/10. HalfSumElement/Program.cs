using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse (Console.ReadLine());
            var max = int.MinValue;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var numbers = int.Parse(Console.ReadLine());
                if (numbers>max )
                {
                    max = numbers;
                   
                }
                sum = sum + numbers;
            }
            sum = sum - max;
            if (sum==max)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum-max)}");
            }
        }
    }
}
