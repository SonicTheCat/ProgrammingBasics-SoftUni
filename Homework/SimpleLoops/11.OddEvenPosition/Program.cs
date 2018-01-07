using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.odd_even_position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0d;
            var oddSum = 0d;
            var maxEven = double.MinValue;
            var maxOdd = double.MinValue;
            var minEven = double.MaxValue ;
            var minOdd = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                var numbers = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += numbers;
                    if (maxEven < numbers)
                    {
                        maxEven = numbers;
                    }
                    if (minEven > numbers)
                    {
                        minEven = numbers;
                    }
                }
                else
                {
                    oddSum += numbers;
                    if (maxOdd < numbers)
                    {
                        maxOdd = numbers;
                    }
                    if (minOdd > numbers)
                    {
                        minOdd = numbers;
                    }
                }
            }
            Console.WriteLine("OddSum" + oddSum);
            if (minOdd==double.MaxValue)
            {
                Console.WriteLine("OddMin = No");
            }
            else
            {
                Console.WriteLine("OddMin = " + minOdd );
            }
            if (maxOdd == double.MinValue)
            {
                Console.WriteLine("OddMax = No");
            }
            else
            {
                Console.WriteLine("OddMax = " + maxOdd);
            }
            Console.WriteLine("EvenSum" + evenSum);
            if (minEven == double.MaxValue)
            {
                Console.WriteLine("EvenMin = No");
            }
            else
            {
                Console.WriteLine("EvenMin = " + minEven);
            }
            if (maxEven == double.MinValue)
            {
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("EvenMax = " + maxEven);
            }
        }

    }
}
