using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGroups = int.Parse(Console.ReadLine());
            var group1 = 0d;
            var group2 = 0d;
            var group3 = 0d;
            var group4 = 0d;
            var group5 = 0d;
            var allStudents = 0d;

            for (int i = 0; i < countOfGroups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                allStudents = allStudents + peopleInGroup;
                if (peopleInGroup<=5)
                {
                    group1 = group1 + peopleInGroup;
                }
                else if (peopleInGroup>5&&peopleInGroup<=12)
                {
                    group2 = group2 + peopleInGroup;
                }
                else if (peopleInGroup > 12 && peopleInGroup <= 25)
                {
                    group3 = group3 + peopleInGroup;
                }
                else if (peopleInGroup > 25 && peopleInGroup <= 40)
                {
                    group4 = group4 + peopleInGroup;
                }
                else if (peopleInGroup >=41)
                {
                    group5 = group5 + peopleInGroup;
                }
            }
            var percentageG1 = group1 / allStudents * 100;
            var percentageG2 = group2 / allStudents * 100;
            var percentageG3 = group3 / allStudents * 100;
            var percentageG4 = group4 / allStudents * 100;
            var percentageG5 = group5 / allStudents * 100;
            Console.WriteLine($"{percentageG1:f2}%");
            Console.WriteLine($"{percentageG2:f2}%");
            Console.WriteLine($"{percentageG3:f2}%");
            Console.WriteLine($"{percentageG4:f2}%");
            Console.WriteLine($"{percentageG5:f2}%");
        }
    }
}
