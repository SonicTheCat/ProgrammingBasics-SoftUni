using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightsToStay = int.Parse(Console.ReadLine());

            double Studio = 50;
            double Apartment = 65;

            if (month=="may"||month=="october")
            {
                if (nightsToStay>7&&nightsToStay<=14)
                {
                    Studio = Studio * 0.95;                
                }
                else if (nightsToStay>14)
                {
                    Studio = Studio * 0.70;
                    Apartment = Apartment * 0.90;
                }
            }
            else if (month=="june"||month=="september")
            {
                 Studio = 75.20;
                 Apartment = 68.70;
                if (nightsToStay>14)
                {
                    Studio = Studio * 0.80;
                    Apartment = Apartment * 0.90;
                }
            }
            else if (month=="july"||month=="august")
            {
                Studio = 76;
                Apartment = 77;
                if (nightsToStay>14)
                {
                    Apartment = Apartment * 0.90;
                }
            }

            Apartment = Apartment * nightsToStay;
            Studio = Studio * nightsToStay; 
            Console.WriteLine($"Apartment: {Apartment:f2} lv.");
            Console.WriteLine($"Studio: {Studio:f2} lv.");

            // ToLower(); не работи правилно ? 
        }
    }
}
