using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenthCM = double.Parse(Console.ReadLine()); 
            double widthCM = double.Parse(Console.ReadLine()); 
            double heightCM = double.Parse(Console.ReadLine()); 
            double percentageFilled = double.Parse(Console.ReadLine());

            var total = lenthCM * widthCM * heightCM;
            total = total * 0.001;
            percentageFilled = percentageFilled * 0.01;
            total = total * (1 - percentageFilled);
            Console.WriteLine($"{total:F3}");
        }
    }
}
