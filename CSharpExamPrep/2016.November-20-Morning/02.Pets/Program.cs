using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysAway = int.Parse(Console.ReadLine());
            int leftFoodInKg = int.Parse(Console.ReadLine());
            double DogFoodKg = double.Parse(Console.ReadLine());
            double CatFoodKg = double.Parse(Console.ReadLine());
            double turtleFoodGr = double.Parse(Console.ReadLine());
            double dogAte = DogFoodKg * daysAway;
            double catAte = CatFoodKg * daysAway;
            double turtleAte = (turtleFoodGr * daysAway)/1000;
            double totalEaten = dogAte + catAte + turtleAte;
            var result = Math.Abs(totalEaten - leftFoodInKg);

            if (totalEaten<=leftFoodInKg)                    
                Console.WriteLine($"{Math.Floor(result)} kilos of food left.");          
            else                      
                Console.WriteLine($"{Math.Ceiling(result)} more kilos of food are needed.");        
        }
    }
}
