using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hoursglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*',2*n+1));
            Console.WriteLine(".*{0}*.",new string(' ',2*n+1-4));
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('.',2+i),new string('@',2*n+1-6-(i*2)));
            }
            Console.WriteLine("{0}*{0}",new string('.',(2*n+1)/2));
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', n - 1 - i), new string(' ', i));
            }
            Console.WriteLine(".*{0}*.", new string('@', 2 * n + 1 - 4));
            Console.WriteLine(new string('*', 2 * n + 1));
        }
    }
}
