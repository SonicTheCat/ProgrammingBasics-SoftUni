using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_Generetor
{
    class Program
    {
        static void Main(string[] args)
        {          
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            for (int i = firstNum; i >=1; i--)
            {
                for (int j = secondNum; j >=1; j--)
                {
                    for (int h = thirdNum; h >= 1; h--)
                    {
                        int number = i * 100 + j * 10 + h;
                        if (number%3==0)
                        {
                            specialNumber += 5;
                        }
                        else if (number % 10 == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine
                                ($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }
                    }   
                }
            }        
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");                  
        }
    }
}
