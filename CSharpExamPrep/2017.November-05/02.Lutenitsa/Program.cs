using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatoesInKG = double.Parse(Console.ReadLine());
            double countOfBoxes = double.Parse(Console.ReadLine());
            double countOfJars = double.Parse(Console.ReadLine());

            double lutenisaKG = tomatoesInKG * 0.20;
            Console.WriteLine($"Total lutenica: {Math.Floor(lutenisaKG)} kilograms.");
            var jars = lutenisaKG / 0.535;
            var boxes = jars / countOfJars;
            if (boxes>countOfBoxes)
            {
                Console.WriteLine($"{Math.Floor(boxes-countOfBoxes)} boxes left.");
                Console.WriteLine($"{Math.Floor(jars-(countOfBoxes*countOfJars))} jars left.");
            }
            else if (boxes<countOfBoxes)
            {
                Console.WriteLine($"{Math.Floor(countOfBoxes-boxes)} more boxes needed.");
                Console.WriteLine($"{Math.Floor((countOfBoxes * countOfJars)-jars)} more jars needed.");
            }

        }
    }
}
