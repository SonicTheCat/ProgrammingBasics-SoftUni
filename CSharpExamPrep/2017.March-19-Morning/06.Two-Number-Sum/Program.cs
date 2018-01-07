using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Two_Number_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum= int.Parse(Console.ReadLine());
            int magicNum= int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = firstNum; i >=secondNum; i--)
            {
                for (int j = firstNum; j >= secondNum; j--)
                {
                    count++;
                    if (i+j==magicNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNum}");
        }
    }
}
