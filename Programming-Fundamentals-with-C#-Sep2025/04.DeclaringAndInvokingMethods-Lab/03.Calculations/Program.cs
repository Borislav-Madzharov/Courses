using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());


            if (operation == "add")
            {
                Addition(first, second);
            }
            else if (operation == "multiply")
            {
                Multiply(first, second);
            }
            else if (operation == "subtract")
            {
                Subtract(first, second);
            }
            else if (operation == "divide")
            {
                Divide(first, second);
            }



        }

        static void Addition(int a,  int b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
