using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {       
            int countOfDeliveries = int.Parse(Console.ReadLine());
            int bus = 0;
            double truck = 0;
            double train = 0;
            double price = 0;  
              
            for (int i = 1; i <=countOfDeliveries; i++)
            {
                int tonageOfDelivery = int.Parse(Console.ReadLine());
                if (tonageOfDelivery<=3)
                {
                    price = price + 200 * tonageOfDelivery;
                    bus = bus + tonageOfDelivery;
                }
                else if (tonageOfDelivery >= 4 && tonageOfDelivery <= 11)
                {
                    price = price + 175 * tonageOfDelivery;
                    truck = truck + tonageOfDelivery;
                }
                else if (tonageOfDelivery >=12)
                {
                    price = price + 120 * tonageOfDelivery;
                    train = train + tonageOfDelivery;
                }
            }
            double sum = bus + truck + train;
            price = price / sum;
            double percentageBus = bus / sum*100;
            double percentageTruck = truck / sum*100;
            double percentageTrain = train / sum*100;

            Console.WriteLine($"{price:f2}");
            Console.WriteLine($"{percentageBus:f2}%");
            Console.WriteLine($"{percentageTruck:f2}%");
            Console.WriteLine($"{percentageTrain:f2}%");


        }
    }
}
