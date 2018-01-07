using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractYears = Console.ReadLine().ToLower();
            string contractType = Console.ReadLine().ToLower();
            string internet = Console.ReadLine().ToLower();
            int monthsToPay = int.Parse(Console.ReadLine());

            var bill =  9.98;
            if (contractYears=="two")
                bill = 8.58;
            if (contractType=="middle")
            {
                bill = 18.99;
                if (contractYears=="two")     
                    bill = 17.09;
            }
            else if (contractType == "large")
            {
                bill = 25.98;
                if (contractYears == "two")
                    bill = 23.59;
            }
            else if (contractType == "extralarge")
            {
                bill = 35.99;
                if (contractYears == "two")
                    bill = 31.79;
            }
            if (internet=="yes"&&bill<=10)
                bill += 5.50;
            else if (internet == "yes" && bill>10&&bill<=30)
                bill += 4.35;
            else if (internet == "yes")            
                bill += 3.85;
            bill *= monthsToPay;
            Console.WriteLine(contractYears=="two"?$"{bill*0.9625:f2} lv.":$"{bill:f2} lv.");
        }
    }
}
