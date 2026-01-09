using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;

            while (number > 0)
            {
                digit = number % 10;
                number /= 10;
                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }
}
