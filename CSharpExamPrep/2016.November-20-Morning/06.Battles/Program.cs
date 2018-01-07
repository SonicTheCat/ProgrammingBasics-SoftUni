using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonFirstPlaya = int.Parse(Console.ReadLine());
            int pokemonSecondPlaya = int.Parse(Console.ReadLine());
            int maxNumOfBattles = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 1; i <=pokemonFirstPlaya; i++)
            {
                for (int j = 1; j <=pokemonSecondPlaya; j++)
                {
                    if (count==maxNumOfBattles)
                    {
                        return;
                    }
                    Console.Write($"({i} <-> {j}) ");
                    count++;
                }
            }
            Console.WriteLine();
        }
    }
}
