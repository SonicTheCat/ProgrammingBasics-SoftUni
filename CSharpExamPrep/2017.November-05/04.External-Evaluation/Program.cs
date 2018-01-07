using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfPupils = double.Parse(Console.ReadLine());
            double poorMark = 0;
            double satisfactoryMark = 0;
            double goodMark = 0;
            double veryGoodMark = 0;    
            double excellentMark = 0;
                
            for (int i = 0; i < countOfPupils; i++)
            {
                double pointsPerPupil = double.Parse(Console.ReadLine());
                if (pointsPerPupil<22.5)
                    poorMark++;
                else if (pointsPerPupil>22.5&&pointsPerPupil<=40.5)
                    satisfactoryMark++;
                else if (pointsPerPupil > 40.5 && pointsPerPupil <=58.5)
                    goodMark++;
                else if (pointsPerPupil >58.5 && pointsPerPupil <=76.5)
                    veryGoodMark++;
                else if (pointsPerPupil > 76.5 && pointsPerPupil <=100)
                    excellentMark++;
            }
            Console.WriteLine($"{poorMark/countOfPupils*100:f2}% poor marks");
            Console.WriteLine($"{satisfactoryMark/countOfPupils * 100:f2}% satisfactory marks");
            Console.WriteLine($"{goodMark/countOfPupils * 100:f2}% good marks");
            Console.WriteLine($"{veryGoodMark/countOfPupils * 100:f2}% very good marks");
            Console.WriteLine($"{excellentMark/countOfPupils * 100:f2}% excellent marks");
        }
    }
}
