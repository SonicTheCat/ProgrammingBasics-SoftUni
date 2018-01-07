using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine().ToLower();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var hall = r * c;
            double income = -1;
            if (ticket=="premiere")
            {
                income = hall * 12.00;
            }
            else if (ticket=="normal")
            {
                income = hall * 7.50; 
            }
            else if(ticket=="discount")
            {
                income = hall * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine().ToLower();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var hall = r * c;
            double income = -1;
            switch (ticket)
            {
                case "premiere": income = hall * 12.00; break;
                case "normal": income = hall * 7.50; break;
                case "discount": income = hall * 5.00; break;

            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
