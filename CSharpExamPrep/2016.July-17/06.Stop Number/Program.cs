using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int StopNum = int.Parse(Console.ReadLine());

            for (int i = M; i >=N; i--)
            {
                if (i%2==0&&i%3==0)
                {                   
                    if (i!=StopNum)
                    {
                        Console.Write(i);
                        Console.Write(" ");                      
                    }
                    else                  
                        return;                
                }
            }
        }
    }
}
