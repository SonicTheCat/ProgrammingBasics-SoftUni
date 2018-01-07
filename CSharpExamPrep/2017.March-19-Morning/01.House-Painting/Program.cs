using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double widthSide= double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());

            var frontSide = height * height-(1.2*2);
            var backSide = height * height;
            var bothSides = (widthSide * height)*2 - (1.5 * 1.5) * 2;
            var house = (frontSide + backSide + bothSides)/3.4;

            var roofSides = (widthSide * height) * 2;
            var frontAndBack = height * heightTriangle;
            var roof = (roofSides + frontAndBack) / 4.3;
            Console.WriteLine($"{house:f2}");
            Console.WriteLine($"{roof:f2}");
        }
    }
}
