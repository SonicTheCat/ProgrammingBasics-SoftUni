using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {       
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double moneyFromMagnolii = magnolii * 3.25;
            double moneyFromZumbuli = zumbuli * 4;
            double moneyFromRozi = rozi * 3.50;
            double moneyFromKaktusi = kaktusi * 8;
            double inComeAfterTax = (moneyFromMagnolii + moneyFromZumbuli + moneyFromRozi + moneyFromKaktusi) * 0.95;
            var result = Math.Abs(inComeAfterTax - giftPrice);
            if (inComeAfterTax>=giftPrice)
            {
               
                Console.WriteLine($"She is left with {Math.Floor(result)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(result)} leva.");
            }
        }
    }
}
