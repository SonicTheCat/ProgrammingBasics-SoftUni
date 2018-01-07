using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double heightB = double.Parse(Console.ReadLine());

            double sidesAndRoof = (sideA * sideA / 2)*4;
            double backAndFront = (sideA / 2)* (sideA / 2)*2- sideA / 5*sideA/5;;
            double Triangle = ((sideA / 2 * (heightB- sideA / 2)) / 2)*2;
            double allSides = sidesAndRoof / 2 + backAndFront + Triangle;
            double roofTop = sidesAndRoof / 2;
            double greenPaint = allSides / 3;
            double redPaint = roofTop / 5;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
