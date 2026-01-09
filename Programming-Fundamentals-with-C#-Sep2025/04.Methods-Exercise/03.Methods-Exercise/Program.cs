using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Methods_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = NumComparer(num1, num2);
            Console.WriteLine(NumComparer(result, num3));


        }

        static int NumComparer(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            return num2;
        }
    }
}
