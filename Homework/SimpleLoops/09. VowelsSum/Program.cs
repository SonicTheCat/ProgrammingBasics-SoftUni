using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < duma.Length; i++)
            {
                char simvol = duma[i];
                if (simvol=='a')
                {
                    sum += 1;
                }
                else if (simvol=='e')
                {
                    sum += 2;
                }
                else if (simvol == 'i')
                {
                    sum += 3;
                }
                else if (simvol == 'o')
                {
                    sum += 4;
                }
                else if (simvol == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
