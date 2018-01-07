using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            double countOfPeople = double.Parse(Console.ReadLine());

            double moneyForTransport = budget * 0.75;
            double moneyForGame = 249.99;

            if (category=="vip")            
                moneyForGame = 499.99;            
            if (countOfPeople>=5&&countOfPeople<=9)
                moneyForTransport = budget * 0.60;
            if (countOfPeople >= 10 && countOfPeople <= 24)
                moneyForTransport = budget * 0.50;            
            if (countOfPeople >= 25 && countOfPeople <= 49)            
                moneyForTransport = budget * 0.40;            
            if (countOfPeople >50)            
                moneyForTransport = budget * 0.25;

            moneyForGame = moneyForGame * countOfPeople;
            var totalMoney =(moneyForGame + moneyForTransport);

            if (totalMoney <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - totalMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalMoney - budget:f2} leva.");

            }  

        }
    }
}
