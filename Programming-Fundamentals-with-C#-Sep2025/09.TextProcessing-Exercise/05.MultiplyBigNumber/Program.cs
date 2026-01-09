using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger value = BigInteger.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            value *= multiplier;
            Console.WriteLine(value);



        }
    }
}
