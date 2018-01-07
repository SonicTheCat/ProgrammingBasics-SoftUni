using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_to_the_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyWill = double.Parse(Console.ReadLine());
            double yearTillLiving = double.Parse(Console.ReadLine());          
            double ivanAge = 18;
            double result = 0;

            for (int year = 1800; year <=yearTillLiving; year++)
            {
                double moneySpend = year % 2 == 1 ? 12000 + (50 * ivanAge) : 12000;
                result = result + moneySpend;
                ivanAge++;
            }
            if (result<=moneyWill)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyWill-result:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {result-moneyWill:f2} dollars to survive.");
            }
        }
    }
}
