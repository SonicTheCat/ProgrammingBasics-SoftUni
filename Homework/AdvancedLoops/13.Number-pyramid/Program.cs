using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (int row = 1; row <=n; row++)
            {

                for (int col = 0; col < row; col++)
                {
                    Console.Write(num);
                    Console.Write(" ");
                    num++;
                    if (num>n)
                    {
                        Console.WriteLine();
                        return;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
