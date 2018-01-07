using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            var holidays = double.Parse(Console.ReadLine());
            var weekendsHome = double.Parse(Console.ReadLine());

            double sofiaWeekends = 48 - weekendsHome;
            double weekendsWork = sofiaWeekends * 0.25;
            weekendsWork = sofiaWeekends - weekendsWork; 

        }
    }
}
