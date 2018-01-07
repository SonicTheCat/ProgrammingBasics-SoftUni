using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {         
            char capitalLetter = char.Parse(Console.ReadLine());
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());
            char letterThree = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            var count = 0;
            for (char a = 'A'; a <=capitalLetter; a++)
            {
                for (char b = 'a'; b <= letterOne; b++)
                {
                    for (char c = 'a'; c <= letterTwo; c++)
                    {
                        for (char d = 'a'; d <= letterThree; d++)
                        {
                            for (int num = 0; num <= number; num++)
                            {
                                if (a==capitalLetter&&b==letterOne&&c==letterTwo&&d==letterThree&&num==number)
                                {
                                    Console.WriteLine(count);
                                    return;
                                }
                                count++;
                            }
                        }
                    }
                }
            }
        }
    }
}
