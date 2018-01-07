using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var num = 0;
            while (true)
            {
                Console.WriteLine("Enter even number: ");
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number!");

                }           
            }
            Console.WriteLine("Even number entered: " + num);
        }
    }
}
