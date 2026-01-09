using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int factorial = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= factorial; i++)
            {
                result *= i;
            }


            Console.WriteLine(result);



        }
    }
}
