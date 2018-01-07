using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_Powers_of_two
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 1;
            for (int i = 0; i <=n/2; i++)
            {
                Console.WriteLine(sum);
                sum = sum * 2 * 2;

            }
        }
    }
}
