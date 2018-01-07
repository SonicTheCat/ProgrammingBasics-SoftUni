using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Letters_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            char begining = char.Parse(Console.ReadLine());
            char ending = char.Parse(Console.ReadLine());
            char stop = char.Parse(Console.ReadLine());
            var count = 0;
            for (char a = begining; a <=ending; a++)
            {
                for (char b = begining; b <=ending; b++)
                {
                    for (char c = begining; c <=ending; c++)
                    {
                        if (a != stop && b != stop&&c!=stop)
                        {
                            count++;
                            Console.Write("{0}{1}{2} ",a,b,c);
                        }
                    }                                 
                }
            }          
            Console.WriteLine(count);
        }
    }
}
