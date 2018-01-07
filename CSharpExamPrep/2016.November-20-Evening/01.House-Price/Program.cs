using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double SqrMeeterPrice = double.Parse(Console.ReadLine());

            double bathRoom = smallestRoom * 0.50;
            double middleRoom = smallestRoom * 1.10;
            double biggestRoom = middleRoom * 1.10;
            double apartment = (smallestRoom + kitchen + bathRoom + middleRoom + biggestRoom)*1.05;
            double apartmentPrice = SqrMeeterPrice * apartment;
            Console.WriteLine($"{apartmentPrice:f2}");
        }
    }
}
