using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var last = 0;
            var sum=0;
            do
            {
                last = n % 10;
                sum = sum + last;
                n = n / 10; 
            } while (n>0);
            Console.WriteLine(sum);
        }
    }
}
