using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
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
