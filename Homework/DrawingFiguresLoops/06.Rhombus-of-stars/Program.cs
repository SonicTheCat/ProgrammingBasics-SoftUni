using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var emptySpaces = n - 1;
            var stars = 1;

            for (int row = 1; row <=n; row++)
            {
                
                for (int i = 1; i <=emptySpaces; i++)
                {
                    Console.Write(" ");                    
                }
                Console.Write("*");
                for (int col = 1; col < stars; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                emptySpaces--;
                stars++;
            }

            emptySpaces = 1;
            stars = n - 1;
            for (int row = 1; row < n; row++)
            {
                for (int i = 1; i <=emptySpaces; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col < stars; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                emptySpaces++;
                stars--;
            }
           
        }

    }
}
