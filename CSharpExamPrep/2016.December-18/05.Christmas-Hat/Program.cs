﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}/|\\{0}",new string('.',n*2-1));
            Console.WriteLine("{0}\\|/{0}",new string('.',n*2-1));
            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",new string('.',n*2-1-i),new string('-',i));
            }
            Console.WriteLine(new string('*',4*n+1));
            for (int i = 0; i < 1; i++)
            {
                for (int col = 0; col < 2*n; col++)
                {
                    Console.Write("*");
                    Console.Write(".");
                }
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', 4*n+1));
        }
    }
}
