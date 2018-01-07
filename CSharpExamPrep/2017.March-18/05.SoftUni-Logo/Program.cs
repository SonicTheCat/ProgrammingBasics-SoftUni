using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = 12 * n - 5;
            var height = 4 * n - 2;          
            var firstDiez = 1;
            var dots = (width - 1) / 2;

            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}{1}{0}",new string('.',dots),new string('#',firstDiez));
                dots -= 3;
                firstDiez += 6;
            }
           
            dots = 3;
            firstDiez = width - 6;
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("|{0}{1}{2}",new string('.',dots-1),new string('#',firstDiez),new string('.',dots));
                dots += 3;
                firstDiez -= 6;
            }
            for (int i = 1; i <=n; i++)
            {                                          
                Console.WriteLine("|{0}{1}{2}", new string('.', dots - 1), new string('#', firstDiez), new string('.', dots));             
            }
            Console.WriteLine("@{0}{1}{2}", new string('.', dots - 1), new string('#', firstDiez), new string('.', dots));
            
        }
    }
}
