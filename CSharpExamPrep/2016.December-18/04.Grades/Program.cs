using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double two = 0;
            double three = 0;
            double four = 0;
            double five = 0;
            double avarage = 0;
            for (int i = 1; i <=students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                avarage += grade;
                if (grade >= 2.00 && grade <= 2.99)
                {
                    two++;
                }
                else if (grade>=3.00 && grade<=3.99)
                {
                    three++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    four++;
                }
                else if (grade >=5.00)
                {
                    five++;
                }
            }
            var percentageTwo = two / students * 100;
            var percentageThree = three / students * 100;
            var percentageFour = four / students * 100;
            var percentageFive = five / students * 100;
            avarage = avarage / students;

            Console.WriteLine($"Top students: {percentageFive:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentageFour:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentageThree:f2}%");
            Console.WriteLine($"Fail: {percentageTwo:f2}%");
            Console.WriteLine($"Average: {avarage:f2}");
        }
    }
}
