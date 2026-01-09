using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 0; i < count; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());

                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
