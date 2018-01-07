using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = -1;
            while (true)
            {             
                try
                {
                    Console.WriteLine("Enter a number");
                    n = int.Parse(Console.ReadLine());
                    if (n>=1&&n<=100)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid number!");
                }
                catch 
                {
                    Console.WriteLine("This is not a number");
                   
                }
                
            }
            Console.WriteLine("The number is: " + n);
        }
    }
}
