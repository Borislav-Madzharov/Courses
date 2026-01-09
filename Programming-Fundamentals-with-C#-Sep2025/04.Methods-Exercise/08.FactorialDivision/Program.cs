using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            decimal divison = (decimal)FactorialNum1(num1) / (decimal)FactorialNum2(num2);
            Console.WriteLine($"{divison:f2}");

        }

        static int FactorialNum1(int num)
        {
            int sum = 1;

            for (int i = num; i > 0; i--)
            {
                sum *= i;
            }

            return sum;
        }
        static int FactorialNum2(int num)
        {
            int sum = 1;

            for (int i = num; i > 0; i--)
            {
                sum *= i;
            }

            return sum;
        }
    }
}
