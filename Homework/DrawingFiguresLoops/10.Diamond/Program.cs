using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var countOfstars = n % 2 == 0 ? 2 : 1;
            var sideDashes = (n - countOfstars) / 2;

            var stars = new string('*', countOfstars);
            var dashes = new string('-', sideDashes);
            Console.WriteLine("{0}{1}{0}", dashes, stars);
            sideDashes--;

            var bodyRows = (n - 1) / 2;
            var midDashes = countOfstars;
            for (int row = 1; row <= bodyRows; row++)
            {
                var Mdashes = new string('-', midDashes);
                var Sdashes = new string('-', sideDashes);
                Console.WriteLine("{0}*{1}*{0}", Sdashes, Mdashes);
                midDashes += 2;
                sideDashes--;
            }
            midDashes -= 4;
            sideDashes += 2;
            bodyRows--;
            for (int row = 1; row <= bodyRows; row++)
            {
                var Mdashes = new string('-', midDashes);
                var Sdashes = new string('-', sideDashes);
                Console.WriteLine("{0}*{1}*{0}", Sdashes, Mdashes);
                midDashes -= 2;
                sideDashes++;
            }
            if (n > 2)
            {
                Console.WriteLine("{0}{1}{0}", dashes, stars);
            }
        }
    }
}
