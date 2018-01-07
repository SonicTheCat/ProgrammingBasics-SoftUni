using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());
            double score = 0;
            double countOne = 0;
            double countTwo = 0;
            double countThree = 0;
            double countFour = 0;
            double countFive = 0;
            double countInvalid = 0;
            
            for (int i = 1; i <=rounds; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number>=0&&number<=9)
                {
                    number = number * 0.20;
                    score = score + number;
                    countOne++;
                }
                else if (number>=10&&number<=19)
                {
                    number = number * 0.30;
                    score = score + number;
                    countTwo++;
                }
                else if (number >= 20 && number <= 29)
                {
                    number = number * 0.40;
                    score = score + number;
                    countThree++;
                }
                else if (number >= 30 && number <= 39)
                {                  
                    score = score + 50;
                    countFour++;
                }
                else if (number >= 40 && number <= 50)
                {               
                    score = score + 100;
                    countFive++;
                }
                else if (number < 0||number>50)
                {
                    score = score / 2;
                    countInvalid++;
                }
            }         
            Console.WriteLine($"{score:f2}");
            Console.WriteLine($"From 0 to 9: {countOne/rounds*100:f2}%");
            Console.WriteLine($"From 10 to 19: {countTwo/rounds*100:f2}%");
            Console.WriteLine($"From 20 to 29: {countThree/rounds*100:f2}%");
            Console.WriteLine($"From 30 to 39: {countFour / rounds * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {countFive / rounds * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {countInvalid / rounds * 100:f2}%");
        }
    }
}
