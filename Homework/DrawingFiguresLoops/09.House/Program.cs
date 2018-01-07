using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 1;
            if (n%2==0)
            {
                stars = 2;
            }
            var dashes = (n - stars) / 2;
            
            for (int rol = 0; rol <(n+1)/2; rol++)
            {
                Console.Write(new string('-',dashes));
                Console.Write(new string('*',stars));
                Console.WriteLine(new string('-', dashes));
                dashes--;
                stars+=2;
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*',n-2));
                Console.WriteLine("|");

            }
        }
    }
}
