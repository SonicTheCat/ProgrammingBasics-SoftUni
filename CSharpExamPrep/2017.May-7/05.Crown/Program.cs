using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = (2 * n) - 1;
            var height = (n / 2) + 4;

            Console.WriteLine("@{0}@{0}@",new string(' ',((2*n)-4)/2));
            Console.WriteLine("**{0}*{0}**", new string(' ', ((2 * n) - 6) / 2));
            for (int i = 0; i < height-6; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', i + 1),
                    new string(' ', (width - 9 - (4 * i)) / 2),
                    new string('.', 2 * i + 1));
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', (n - 1) / 2), new string('.', n - 3));                   
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', (n - 4)/2));
            Console.WriteLine(new string('*',width));           
            Console.WriteLine(new string('*',width));           
        }
    }
}
