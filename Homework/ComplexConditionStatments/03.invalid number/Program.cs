using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var inRange = (num >= 100 && num <= 200)||(num==0);
            
            if (!inRange)
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
