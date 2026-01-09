using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //int currentNum = 0;
            int sum = 0;

            foreach  ( int currentNum in numbers)
            {
                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(sum);




        }
    }
}
