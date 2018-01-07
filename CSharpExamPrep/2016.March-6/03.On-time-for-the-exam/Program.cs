using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_time_for_the_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double examH = double.Parse(Console.ReadLine());
            double examM = double.Parse(Console.ReadLine());
            double arivingH = double.Parse(Console.ReadLine());
            double arivingM = double.Parse(Console.ReadLine());

            double lateHour = 0;
            double lateMin = 0;
            double onTime = 0;
            double earlyHour = 0;
            double earlyMin = 0;

            double converterExamMin = examH * 60 + examM;
            double converterArivingMin = arivingH * 60 + arivingM;
            if (converterExamMin>converterArivingMin+30)
            {
                earlyHour = (converterExamMin - converterArivingMin) / 60;
                earlyMin = (converterExamMin - converterArivingMin) % 60;
                if (earlyHour!=0)
                {
                    Console.WriteLine("Early");
                    if (earlyMin<10)
                    {
                       
                        Console.WriteLine($"{earlyHour}:0{earlyMin} hours before the start");
                        return;
                    }                  
                    Console.WriteLine($"{earlyHour}:{earlyMin} hours before the start");
                }
                else if (earlyHour == 0)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{earlyMin} minutes before the start");
                }
            }              
            else if (converterArivingMin>converterExamMin)
            {
                Console.WriteLine("Late");
                lateHour = (converterArivingMin-converterExamMin) / 60;
                lateMin = (converterArivingMin - converterExamMin) % 60;

                if (lateHour!=0&&lateMin>=10)
                {                   
                    Console.WriteLine($"{lateHour}:{lateMin} hours after the start");                 
                }
                else if (lateHour!=0&&lateMin<10)
                {                 
                    Console.WriteLine($"{lateHour}:0{lateMin} hours after the start");
                }            
                else if(lateHour == 0)
                {                
                    Console.WriteLine($"{lateMin} minutes after the start");
                }               
            }
            else if(converterExamMin==converterArivingMin)
            {
                Console.WriteLine("On time");             
            }
            else if (converterExamMin>converterArivingMin)
            {
                onTime = converterExamMin - converterArivingMin;
                Console.WriteLine("On time");
                Console.WriteLine($"{onTime} minutes before the start");
            }
        }
    }
}
