using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Сбор_или_произведение
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            var count = 0;
            for (int num1 = 1; num1 <=30; num1++)
            {
                for (int num2 = 1; num2 <=30; num2++)
                {
                    for (int num3 = 1; num3 <=30; num3++)
                    {
                        if (num1<num2&&num2<num3&&num1+num2+num3==controlNumber)
                        {
                            count = 1;
                            Console.WriteLine($"{num1} + {num2} + {num3} = {controlNumber}");
                        }
                        if (num1 > num2 && num2 > num3 && num1 * num2 * num3 == controlNumber)
                        {
                            count = 1;
                            Console.WriteLine($"{num1} * {num2} * {num3} = {controlNumber}");
                        }
                    }
                }
            }
            if (count==0)
                Console.WriteLine("No!");
        }
    }
}
