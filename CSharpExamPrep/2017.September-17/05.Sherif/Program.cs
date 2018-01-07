using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sherif
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = 3 * n;
            Console.WriteLine("{0}x{0}",new string('.',(width-1)/2));
            Console.WriteLine("{0}/x\\{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x|x{0}", new string('.', (width - 3) / 2));
            for (int i = 0; i < n/2+1; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",new string('.',n/2-i),new string('x',n+i));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', i+1), new string('x',(width-3)/2-i));
            }
            Console.WriteLine("{0}/x\\{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\x/{0}", new string('.', (width - 3) / 2));
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', n / 2 - i), new string('x', n + i));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', i + 1), new string('x', (width - 3) / 2 - i));
            }
            Console.WriteLine("{0}x|x{0}", new string('.', (width - 3) / 2));        
            Console.WriteLine("{0}\\x/{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}x{0}", new string('.', (width - 1) / 2));


        }
    }
}
