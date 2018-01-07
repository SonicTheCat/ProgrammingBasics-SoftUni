using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinsOneLev = int.Parse(Console.ReadLine());
            int coinsTwoLeva = int.Parse(Console.ReadLine());
            int fiveLeva = int.Parse(Console.ReadLine());
            int Sum = int.Parse(Console.ReadLine());

            for (int one = 0; one <=coinsOneLev; one++)
            {
                for (int two = 0; two <=coinsTwoLeva; two++)
                {
                    for (int five = 0; five <=fiveLeva; five++)
                    {
                        if ((one*1)+(two*2)+(five*5)==Sum)
                        {
                            Console.WriteLine($"{one} * 1 lv. + {two} * 2 lv. + {five} * 5 lv. = {Sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
