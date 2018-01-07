using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            double Liliage = double.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double Money = 0;
            double savedMoney = 0;
            double toys = 0;
            for (int age = 1; age <=Liliage; age++)
            {
                if (age%2==0)
                {
                    Money = Money + 10;
                    savedMoney += Money-1;
                }
                else
                {
                    toys++;
                }
            }
            toyPrice = toyPrice * toys;
            savedMoney = savedMoney + toyPrice;
            if (savedMoney>=washingMachine)
            {
                Console.WriteLine($"Yes! {(savedMoney-washingMachine):f2}");
            }
            else if (washingMachine>savedMoney)
            {
                Console.WriteLine($"No! {(washingMachine - savedMoney):f2}");
            }

        }
    }
}
