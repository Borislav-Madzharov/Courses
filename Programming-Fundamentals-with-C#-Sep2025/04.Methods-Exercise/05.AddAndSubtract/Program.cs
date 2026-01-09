using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            int result = Sum(num1, num2);
            Subtract(result, num3);
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Subtract(int result, int num3)
        {
            int final= result - num3;
            Console.WriteLine(final);
        }
    }
}
