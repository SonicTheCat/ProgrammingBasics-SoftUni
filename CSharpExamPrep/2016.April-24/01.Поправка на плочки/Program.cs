using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaPlayGround = double.Parse(Console.ReadLine());
            double tailWidth = double.Parse(Console.ReadLine());
            double tailLenth = double.Parse(Console.ReadLine());
            double benchWidth = double.Parse(Console.ReadLine());
            double benchLenth = double.Parse(Console.ReadLine());

            double areaTail = tailLenth * tailWidth;
            double areaBench = benchLenth * benchWidth;
            areaPlayGround = (areaPlayGround * areaPlayGround)- areaBench;
            double tailNeeded = areaPlayGround / areaTail;
            double timeNeeded = tailNeeded * 0.2;

            Console.WriteLine($"{tailNeeded:f2}");
            Console.WriteLine($"{timeNeeded:f2}");


        }
    }
}
