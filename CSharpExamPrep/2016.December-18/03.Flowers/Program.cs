using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int boughHhrizantemi = int.Parse(Console.ReadLine());
            int boughtRozi = int.Parse(Console.ReadLine());
            int boughtLaleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine();
            double hrizantemi = 2.00;
            double rozi = 4.10;
            double laleta = 2.50;        
                          
            if (season=="winter"||season=="autumn")
            {
                hrizantemi = 3.75;
                rozi = 4.50;
                laleta = 4.15;                      
            }
            double boquet = (hrizantemi * boughHhrizantemi) + (rozi * boughtRozi) + (laleta * boughtLaleta);
                    
            if (holiday=="Y")
            {             
                boquet *= 1.15;
            }
            if (boughtLaleta > 7 && season == "spring")
            {
                boquet *= 0.95;
            }
            if (boughtRozi >= 10 && season == "winter")
            {
                boquet *= 0.90;
            }
            if (boughtRozi + boughtLaleta + boughHhrizantemi > 20)
            {
                boquet *= 0.80;             
            }         
            Console.WriteLine($"{boquet+2:f2}");
        }
    }
}
