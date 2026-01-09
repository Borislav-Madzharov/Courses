using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] allNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int evenSum = 0;
            int oddSum = 0;


            foreach (int currentNum in allNumbers)
            {

                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }

            }

            int allSum = evenSum - oddSum;

            Console.WriteLine(allSum);







        }
    }
}
