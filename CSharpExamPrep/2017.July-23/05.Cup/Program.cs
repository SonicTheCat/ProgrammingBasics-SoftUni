﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}",new string ('.',n+i),new string('#',n*3-i*2));
            }
            for (int i = 0; i < (n/2)+1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', n + (n/2)+i), new string('.', n*2-2-i*2));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', 2*n), new string('#', n));
            for (int i = 1; i <=n+2; i++)
            {
                if (i==(n+2)/2)              
                    Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.',(5*n-10)/2 ));
                else
                    Console.WriteLine("{0}{1}{0}", new string('.', n * 2 - 2), new string('#', n + 4));            
            }
        }
    }
}
