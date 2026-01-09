using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            decimal num2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(OperationManager(num1, operation, num2));





        }



        static decimal OperationManager(decimal num1, string operation, decimal num2)
        {
            decimal result = 0;
            if (operation == "/")
            {
                result = num1 / num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            return result;
        }

    }
}
