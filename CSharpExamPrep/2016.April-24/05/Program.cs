using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",new string('.',n+1),new string('_',n*2+1));
            for (int i = 0; i < n+1; i++)
            {           
                if (i!=n)                
                    Console.WriteLine(@"{0}//{1}\\{0}", new string('.', n - i), new string('_', (n * 2 - 1) + (i * 2)));
                else
                    Console.WriteLine(@"{0}//{1}STOP!{1}\\{0}", new string('.', n - i),
                      new string('_', (n * 2 - 3)));            
            }
            for (int j = 0; j < n; j++)          
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.',j),new string('_',(n*4-1)-(j*2)));         
        }
    }
}
