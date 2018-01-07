using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {         
            double kmPerHour = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime= double.Parse(Console.ReadLine());
            double thirdTime= double.Parse(Console.ReadLine());

            var kmFirst = kmPerHour * (firstTime/60);
            kmPerHour = kmPerHour * 1.10;
            var kmSecond = kmPerHour * (secondTime / 60);
            kmPerHour = kmPerHour * 0.95;
            var kmThird = kmPerHour * (thirdTime / 60);
            var total = kmFirst + kmSecond + kmThird;
            Console.WriteLine($"{total:f2}");

        }
    }
}
