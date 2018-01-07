using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int maxCombinations= int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = firstNum; i <=secondNum; i++)
            {
                for (int j = firstNum; j <=secondNum; j++)
                {
                    if (count==maxCombinations)
                    {
                        Console.WriteLine();
                        return;
                    }
                    Console.Write($"<{i}-{j}>");
                    count++;
                }
            }
            Console.WriteLine();
        }
    }
}
