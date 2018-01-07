using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.The_Song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());
            var counter = 0;
            var sum = 0;
            
            for (int a = 1; a <=9; a++)
            {
                for (int b = 1; b <=9; b++)
                {
                    for (int c = 1; c <=9; c++)
                    {
                        for (int d = 1; d <=9; d++)
                        {
                            if (a<b&&c>d&&(a*b)+(c*d)==controlNum)
                            {                             
                                Console.Write($"{a}{b}{c}{d} ");
                                counter++;
                                if (counter==4)
                                {
                                    sum = (a * 1000) + (b * 100) + (c * 10) + d;
                                }                             
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (counter >= 4)             
                Console.WriteLine($"Password: {sum}");
            else
                Console.WriteLine("No!");              
        }
    }
}
