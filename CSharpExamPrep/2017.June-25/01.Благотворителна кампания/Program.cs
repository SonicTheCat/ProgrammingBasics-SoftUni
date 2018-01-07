using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Благотворителна_кампания
{
    class Program
    {
        static void Main(string[] args)
        {         
            int countOfDays = int.Parse(Console.ReadLine());
            int countOfBakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofrets = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());


            var cakesInCome = cakes * 45;
            var gofretsInCome = gofrets *5.80;
            var pancakesInCome = pancakes * 3.20;
            var oneDayInCome = (cakesInCome + gofretsInCome + pancakesInCome)*countOfBakers;
            var totalInCome = (oneDayInCome * countOfDays);
            totalInCome = totalInCome*0.875;

            Console.WriteLine($"{totalInCome:f2}");

        }
    }
}
