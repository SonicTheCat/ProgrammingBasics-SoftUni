using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var spaces = n;
            var stars = 0;

            for (int row = 1; row <= n+1; row++)
            {
                for (int col = 0; col < spaces; col++)
                {
                    Console.Write(" ");
                 
                }
                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");

                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                spaces--;
                stars++;



            } 

        }
    }
}
