using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            var max = int.MinValue;
            for (int i = 1; i <=n; i++)
            {
              var num1 = int.Parse(Console.ReadLine());
                if (num1>max)
                {
                    max = num1;
                }
            }
            Console.WriteLine(max);
        }
    }
}
