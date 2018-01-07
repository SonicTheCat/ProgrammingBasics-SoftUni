using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double deliveryInKg = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine(); 
            double distanceInKM = double.Parse(Console.ReadLine());

            var price = 0.03;
            var expressTax = 0d;

            if (deliveryInKg>=1&&deliveryInKg<=10)
                price = 0.05;
            else if (deliveryInKg >= 11 && deliveryInKg <= 40)
                price = 0.10;
            else if (deliveryInKg >= 41 && deliveryInKg <= 90)
                price = 0.15;
            else if (deliveryInKg >= 91 && deliveryInKg <= 150)
                price = 0.20;

            price = price * distanceInKM;

            if (serviceType=="express")
            {
                if (deliveryInKg<1)
                    expressTax = deliveryInKg*(price*0.80);
                else if (deliveryInKg >= 1 && deliveryInKg <= 10)
                    expressTax = deliveryInKg * (price * 0.40);
                else if (deliveryInKg >= 11 && deliveryInKg <= 40)
                    expressTax = deliveryInKg * (price * 0.05);
                else if (deliveryInKg >= 41 && deliveryInKg <= 90)
                    expressTax = deliveryInKg * (price *0.02);
                else if (deliveryInKg >= 91 && deliveryInKg <= 150)
                    expressTax = deliveryInKg * (price * 0.01);              
            }
            Console.WriteLine
                ($"The delivery of your shipment with weight of {deliveryInKg:f3} kg. would cost {price+expressTax:f2} lv.");
        }
    }
}
