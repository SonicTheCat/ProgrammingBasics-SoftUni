using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.trade_comission
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            var sells = double.Parse(Console.ReadLine());
            var comission = -1.0; 
            if (city=="sofia")
            {
                if (0 <= sells && sells <= 500) comission = 0.05;
                else if (500 < sells && sells <= 1000) comission = 0.07;
                else if (1000 < sells && sells <= 10000) comission = 0.08;
                else if (sells > 10000) comission = 0.12;
            }
           else if (city == "varna")
            {
                if (0 <= sells && sells <= 500) comission = 0.045;
                else if (500 < sells && sells <= 1000) comission = 0.075;
                else if (1000 < sells && sells <= 10000) comission = 0.10;
                else if (sells > 10000) comission = 0.13;
            }
            else if (city == "plovdiv")
            {
                if (0 <= sells && sells <= 500) comission = 0.055;
                else if (500 < sells && sells <= 1000) comission = 0.08;
                else if (1000 < sells && sells <= 10000) comission = 0.12;
                else if (sells > 10000) comission = 0.145;
            }
            if (comission>0)
            {
                Console.WriteLine($"{sells*comission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
