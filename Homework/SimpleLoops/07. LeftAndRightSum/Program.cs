using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
            for (int i = 1; i <=n*2; i++)
            {
                int X = int.Parse(Console.ReadLine());
                if (i > n)
                {
                    leftSum += X;
                }
                else
                    rightSum += X;
            }
           
            if (leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                var diffrence = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff =  {diffrence}");
            }
        }
    }
}
