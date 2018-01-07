using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            int periodOfTime = int.Parse(Console.ReadLine());
            int doctors = 7;
            int unCheked = 0;
            int cheked = 0;
            for (int i = 1; i <=periodOfTime; i++)
            {
                if (i % 3 == 0 && unCheked > cheked)
                {
                    doctors++;
                }
                int patients = int.Parse(Console.ReadLine());                
                if (patients>doctors)
                {
                    unCheked = unCheked + (patients - doctors);
                }
                if (patients<=doctors)
                {
                    cheked = cheked + patients;
                }
                else
                {
                    cheked = cheked + doctors;
                }                  
            }
            Console.WriteLine($"Treated patients: {cheked}.");
            Console.WriteLine($"Untreated patients: {unCheked}.");

        }
    }
}
