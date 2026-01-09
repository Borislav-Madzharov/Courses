using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number {number} is {output(number)}.");

        }

        static string output(int num )
        {
            if (num > 0)
            {
                return "positive";
            }
            else if (num < 0)
            {
                return "negative";
            }
            else if (num == 0)
            {
                return "zero";
            }
            return "idk";



        }
    }
}
