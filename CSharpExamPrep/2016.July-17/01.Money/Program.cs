using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {

            double bitCoin = double.Parse(Console.ReadLine());
            double chineeseMoney = double.Parse(Console.ReadLine());
            double changeTaxes = double.Parse(Console.ReadLine());

            double bitCoinInLeva = bitCoin * 1168;
            double chineeseMoneyInUSD = chineeseMoney * 0.15;
            double chineesMoneyInLeva = chineeseMoneyInUSD * 1.76;
            double moneyInEuro = (bitCoinInLeva + chineesMoneyInLeva) / 1.95;
            changeTaxes = changeTaxes * 0.01;
            changeTaxes = moneyInEuro * changeTaxes;
            moneyInEuro = moneyInEuro - changeTaxes;
            Console.WriteLine($"{moneyInEuro:f2}");
          
        }
    }
}
