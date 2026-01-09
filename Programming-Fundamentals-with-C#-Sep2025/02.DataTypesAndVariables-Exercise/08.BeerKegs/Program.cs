using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * π * r^2 * h. 
             * 
             * 
             * •	First – model – string
                  	Second –radius – floating-point number
	                Third – height – integer number

                    2
                    Smaller Keg
                    2,41
                    10
                    Bigger Keg
                    5,12
                    20

             */

            int kegCount = int.Parse(Console.ReadLine());
            string model = "";
            decimal radius = 0;
            decimal height = 0;
            decimal volume = 0;

            decimal biggestVolume = decimal.MinValue;
            string biggestKeg = "";

            for (int i = 0; i < kegCount; i++)
            {
                model = Console.ReadLine();
                radius = decimal.Parse(Console.ReadLine());
                height = decimal.Parse(Console.ReadLine());

                volume = (decimal)Math.PI * (radius * radius) * height;

                if (volume >= biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = model;
                }

            }

            Console.WriteLine(biggestKeg);


        }
    }
}
