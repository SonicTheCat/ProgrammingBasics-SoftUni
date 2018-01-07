using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Специални_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int firsNum = 1; firsNum <=9; firsNum++)
            {
                for (int secondNum = 1; secondNum <=9; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <=9; thirdNum++)
                    {
                        for (int fourthNum = 1; fourthNum <=9; fourthNum++)
                        {
                            if (n%firsNum==0&&n%secondNum==0&&n%thirdNum==0&&n%fourthNum==0)
                            {
                                Console.Write($"{firsNum}{secondNum}{thirdNum}{fourthNum} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
