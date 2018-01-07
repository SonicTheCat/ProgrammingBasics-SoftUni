using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int thirdNum = num % 10;
            int secondNum = (num / 10) % 10;
            int firstNum = num / 100;
            int rows = firstNum + secondNum;
            int cols = firstNum + thirdNum;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (num%5==0)
                    {
                        num = num - firstNum;
                        Console.Write($"{num} ");
                    }
                    else if (num%3==0)
                    {
                        num = num - secondNum;
                        Console.Write($"{num} ");
                    }
                    else
                    {
                        num = num + thirdNum;
                        Console.Write($"{num} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
