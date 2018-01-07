
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = (4 * n) + 1;
            var height = (2 * n) + 1;
            var dashes = n * 2 - 1;
            var dots = 1;
            var emptySpaces = 1;

            Console.WriteLine(new string('#', width));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dots), new string('#', dashes),
        new string(' ', emptySpaces));
                dots++;
                dashes -= 2;
                emptySpaces += 2;
            }
            Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', dots), new string('#', dashes),
                  new string(' ', (emptySpaces - 3) / 2));

            for (int i = 0; i <(n-1)/2; i++)
            {
                dots++;
                dashes -= 2;
                emptySpaces += 2;
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dots), new string('#', dashes),
        new string(' ', emptySpaces));
            }
            for (int i = 0; i < n; i++)
            {
                dots++;
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', emptySpaces));
                emptySpaces -= 2;
            }
        }
    }
}

