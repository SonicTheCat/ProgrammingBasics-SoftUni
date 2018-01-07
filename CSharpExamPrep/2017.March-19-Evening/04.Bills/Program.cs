using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            double periodOfTime = double.Parse(Console.ReadLine());           
            var electricity = 0d;
            var others = 0d;
            var bills = 0d;   
                  
            for (int i = 0; i < periodOfTime; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());
                bills = (35 + electricityBill) * 1.20;
                electricity += electricityBill;
                others += bills;               
            }
            var final = electricity + others + 35 * periodOfTime;
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {20*periodOfTime:f2} lv");
            Console.WriteLine($"Internet: {15*periodOfTime:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {final/periodOfTime:f2} lv");
        }
    }
}
