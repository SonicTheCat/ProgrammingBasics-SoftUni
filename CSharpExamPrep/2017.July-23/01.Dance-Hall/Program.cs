using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLenth = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double withDrowSide = double.Parse(Console.ReadLine());

            double hallSize = (hallLenth*100) * (hallWidth*100);
            hallSize = hallSize - (hallSize / 10) - ((withDrowSide*100) * (100*withDrowSide));
            double dancersInside = hallSize / 7040;

            Console.WriteLine($"{Math.Floor(dancersInside)}");

        }
    }
}
