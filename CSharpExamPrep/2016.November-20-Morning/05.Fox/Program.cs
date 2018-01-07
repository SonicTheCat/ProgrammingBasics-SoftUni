using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());        
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string('*',1+i),new string('-',(n*2-1)-(i*2)));
            }
            for (int j = 0; j < n/3; j++)
            {
                Console.WriteLine(@"|{0}\{1}/{0}|", new string('*', n/2 + j),new string('*',n - j*2));
            }
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(@"{0}\{1}/{0}",new string('-',1+k),new string('*',(n*2-1)-(k*2)));
            }
        }
    }
}
