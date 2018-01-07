using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string sex = Console.ReadLine();
            double pupils = double.Parse(Console.ReadLine());
            double countOfdays = double.Parse(Console.ReadLine());
            string sport = "Judo"; 
            var priceHotel = countOfdays * 9.60;

            if (sex=="girls")
            {
                sport = "Gymnastics";
            }
            if (sex=="mixed")
            {
                priceHotel = countOfdays * 10;
                sport = "Ski";
            }
            if (season=="spring")
            {
                sport = "Tennis"; 
                if (sex=="girls")
                {
                    sport = "Athletics";
                }
                priceHotel = countOfdays * 7.20;
                if (sex=="mixed")
                {
                    priceHotel = countOfdays * 9.50;
                    sport = "Cycling";
                }
            }
            if (season == "summer")
            {
                sport = "Football";

                priceHotel = countOfdays * 15;
                if (sex=="girls")
                {
                    sport = "Volleyball";
                }
                if (sex == "mixed")
                {
                    priceHotel = countOfdays * 20;
                    sport = "Swimming";
                }
            }
            if (pupils>=50) priceHotel *= 0.50;
            else if (pupils>=20&&pupils<50) priceHotel *= 0.85;
            else if (pupils>=10&&pupils<20) priceHotel *= 0.95;
            priceHotel = priceHotel * pupils;

            Console.WriteLine($"{sport} {priceHotel:f2} lv.");
        }
    }
}
