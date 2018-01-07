using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int grownUp = int.Parse(Console.ReadLine());
            int pupils = int.Parse(Console.ReadLine());
            int countOfNights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();         
            double hotelPrice = 82.99*countOfNights;
            var price = 0d;

            if (transport=="train")
            {
                price = (grownUp * 24.99) + (pupils * 14.99);
                if (grownUp+pupils >= 50)
                    price = price * 0.50; 
            }
            else if (transport=="bus")
                price= (grownUp * 32.50) + (pupils * 28.50);
            else if (transport == "boat")           
                price = (grownUp * 42.99) + (pupils * 39.99);
            else if (transport == "airplane")
                price = (grownUp * 70.00) + (pupils * 50.00);

            var totalPrice = ((price*2) + hotelPrice) * 1.10;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
