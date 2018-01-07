using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        { 
            double savedMoney = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLenth = double.Parse(Console.ReadLine());
            double tailSide = double.Parse(Console.ReadLine());
            double tailH = double.Parse(Console.ReadLine());
            double priceForTail = double.Parse(Console.ReadLine());
            double masterPrice = double.Parse(Console.ReadLine());

            double floorArea = floorWidth * floorLenth;
            double tailArea = (tailSide * tailH) / 2;
            double tailNeeded = floorArea / tailArea;
            tailNeeded = Math.Ceiling(tailNeeded) + 5;
            double price = tailNeeded * priceForTail + masterPrice;

            if (price<=savedMoney)
            {
                Console.WriteLine("{0:f2} lv left.",savedMoney-price);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",price-savedMoney);
            }

        }
    }
}
