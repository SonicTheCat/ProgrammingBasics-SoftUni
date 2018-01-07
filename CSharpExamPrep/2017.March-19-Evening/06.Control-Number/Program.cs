using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int countMoves = 0;
            int sum = 0;

            for (int i = 1; i <=firstNum; i++)
            {
                for (int j = secondNum; j >=1; j--)
                {
                    countMoves++;
                    sum += (i * 2) + (j * 3);
                    if (sum>=controlNumber)
                    {
                        Console.WriteLine($"{countMoves} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{countMoves} moves");
        }
    }
}
