using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            var treatedPatients = 0;
            var UnTreatedPatients = 0;
            var doctors = 7;
            for (int i = 1; i <=days; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if ((i%3==0)&&(UnTreatedPatients>treatedPatients))
                {
                    doctors++;
                }
                if (patients>doctors)
                {
                    treatedPatients +=doctors;
                    UnTreatedPatients = UnTreatedPatients+ (patients - doctors);                 
                }
                else
                {
                    treatedPatients += patients;
                  
                }


            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {UnTreatedPatients}.");
          
        }
    }
}
