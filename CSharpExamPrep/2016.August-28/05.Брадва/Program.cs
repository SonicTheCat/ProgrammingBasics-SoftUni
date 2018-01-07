using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            var leftDashes = n * 3;
            var midleDashes = n - 1;
            var rightDashes = n - 1;

            for (int rowOne = 0; rowOne < n; rowOne++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',n*3),new string('-',rowOne),
                    new string('-',(n*2)-2-rowOne));
            }
            for (int rowTwo = 0; rowTwo < n/2; rowTwo++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', n * 3), new string('-', n-1),
                    new string('-', n-1));
            }
            for (int rowThree = 1; rowThree < n / 2; rowThree++)
            {           
                Console.WriteLine("{0}*{1}*{2}", new string('-',leftDashes ), new string('-', midleDashes),
                    new string('-', rightDashes));
                leftDashes--;
                midleDashes += 2;
                rightDashes--;
               
            }
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('*', midleDashes),
                   new string('-', rightDashes));

        }
    }
}
