using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysAtWorkMontly = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double dollarsToLeva= double.Parse(Console.ReadLine());

            double bonus = (daysAtWorkMontly * moneyPerDay) * 2.5;
            double sallaryPerYear = ((daysAtWorkMontly * moneyPerDay) * 12)+bonus;
            double afterTaxes = sallaryPerYear * 0.75;
            double sallaryInLEva = afterTaxes * dollarsToLeva;
            double sallaryPerDay = sallaryInLEva / 365;
            Console.WriteLine($"{sallaryPerDay:f2}");

        }
    }
}
