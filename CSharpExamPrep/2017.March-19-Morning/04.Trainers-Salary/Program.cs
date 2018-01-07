using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfLectures = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            budget = budget / countOfLectures;
            int Jelev = 0;
            int RoYaL = 0;
            int Roli = 0;
            int Trofon = 0;
            int Sino = 0;
            int Others = 0;
            for (int i = 0; i < countOfLectures; i++)
            {
                string name = Console.ReadLine();
                if (name=="Jelev")
                {
                    Jelev++;
                }
                else if (name == "RoYaL")
                {
                    RoYaL++;
                }
                else if (name == "Roli")
                {
                    Roli++;
                }
                else if (name == "Trofon")
                {
                    Trofon++;
                }
                else if (name == "Sino")
                {
                    Sino++;
                }
                else 
                {
                    Others++;
                }
            }
            Console.WriteLine($"Jelev salary: {Jelev*budget:f2} lv");
            Console.WriteLine($"RoYaL salary: {RoYaL * budget:f2} lv");
            Console.WriteLine($"Roli salary: {Roli * budget:f2} lv");
            Console.WriteLine($"Trofon salary: {Trofon * budget:f2} lv");
            Console.WriteLine($"Sino salary: {Sino * budget:f2} lv");
            Console.WriteLine($"Others salary: {Others * budget:f2} lv");
        }
    }
}
