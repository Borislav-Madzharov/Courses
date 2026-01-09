using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();

            foreach (decimal curretNum in numbers)
            {

                if (curretNum != -0)
                {
                    Console.WriteLine($"{curretNum} => {Math.Round(curretNum, MidpointRounding.AwayFromZero)}");
                }
                else
                {
                    Console.WriteLine($"-0 => 0");
                }
                
            }



            /*
              0,9 1,5 2,4 2,5 3,14
             
             */

        }
    }
}
