using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstNum = 1; firstNum <=9; firstNum++)
            {
                for (int secondNum = 1; secondNum <= 9; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <=9; thirdNum++)
                    {
                        for (int fourthNum = 1; fourthNum <=9; fourthNum++)
                        {
                            if (firstNum+secondNum==thirdNum+fourthNum&& n%(firstNum+secondNum)==0)
                            {
                                Console.Write($"{firstNum}{secondNum}{thirdNum}{fourthNum} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
