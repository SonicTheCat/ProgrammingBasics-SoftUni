using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());


            double workPlaceW = (width * 100) - 100;
            workPlaceW = (workPlaceW / 70);
            workPlaceW = Math.Floor(workPlaceW);
            double workPlaceH = (height * 100) / 120;
            workPlaceH = Math.Floor(workPlaceH);
            double total = (workPlaceW * workPlaceH) - 3;
            Console.WriteLine(total);
        }
            
    }
}
