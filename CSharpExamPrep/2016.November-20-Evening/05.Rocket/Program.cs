using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = 3 * n;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}/{1}\{0}", new string('.', width / 2 - i-1), new string(' ', i * 2));
            }
            Console.WriteLine("{0}{1}{0}",new string('.',n/2),new string('*',width-n));
            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine(@"{0}|{1}|{0}", new string('.', n/2), new string('\\', n*2-2));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(@"{0}/{1}\{0}", new string('.', n / 2-i), new string('*', n * 2 - 2+i*2));
            }
        }
    }
}
