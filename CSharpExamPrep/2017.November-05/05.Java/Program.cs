using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = 3 * n + 6;
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}~ ~ ~{1}",new string(' ',n), new string(' ', n*2));
            Console.WriteLine(new string('=',3*n+5));
            for (int i = 0; i < n-2; i++)
            {             
                    if (i==(n-2)/2)
                        Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', n - 1));
                    else
                        Console.WriteLine("|{0}|{1}|", new string('~', width - n - 2), new string(' ', n - 1));          
            }
            Console.WriteLine(new string('=', 3 * n + 5));
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}\\{1}/", new string(' ', i), new string('@', (width - n - 2) - (i * 2)));               
            Console.WriteLine(new string('=', width-n));
        }
    }
}
