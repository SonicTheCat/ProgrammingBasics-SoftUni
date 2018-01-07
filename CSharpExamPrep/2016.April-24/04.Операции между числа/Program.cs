using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            char operant = char.Parse(Console.ReadLine());
            double result = 0;
           
            if (operant=='+')
            {
                result = num1 + num2;
            }
            else if (operant=='-')
            {
                result = num1 - num2;
            }
            else if (operant == '*')
            {
                result = num1 * num2;
            }
            else if (operant == '/')
            {               
                if (num2==0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} {operant} {num2} = {result:F2}");
                }             
            }
            else if (operant == '%')
            {            
                if (num2==0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} {operant} {num2} = {result}");
                }
            }
            var evenOrOdd = result % 2 == 0 ? "even" : "odd";
            if (operant=='+'|| operant == '-' || operant == '*')
            {              
                Console.WriteLine($"{num1} {operant} {num2} = {result} - {evenOrOdd}");
            }
        }
    }
}
