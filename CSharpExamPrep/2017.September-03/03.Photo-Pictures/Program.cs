using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPictures = int.Parse(Console.ReadLine());
            string typeOfPictures = Console.ReadLine();
            string order = Console.ReadLine();

            var price = 0.16*countOfPictures;
            if (countOfPictures>=50)
                price = price * 0.95;
            if (typeOfPictures=="10X15")
            {
                price = 0.16 * countOfPictures;
                if (countOfPictures>=80)
                    price = price * 0.97;
            }
            else if (typeOfPictures == "13X18")
            {
                price = 0.38 * countOfPictures;
                if (countOfPictures>=50&&countOfPictures<=100)
                    price = price * 0.97;
                if (countOfPictures>100)
                    price = price * 0.95;
            }
            else if (typeOfPictures == "20X30")
            {
                price = 2.90 * countOfPictures;
                if (countOfPictures >= 10 && countOfPictures <= 50)
                    price = price * 0.93;
                if (countOfPictures > 50)
                    price = price * 0.91;
            }
            Console.WriteLine(order=="online" ? $"{price*0.98:f2}BGN":$"{price:f2}BGN");
        }
    }
}
