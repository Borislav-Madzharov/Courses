using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine(GetArea(sideA, sideB));
        }

        static double GetArea(double sideA, double sideB)
        { 
            return sideA * sideB;

        }
    }
}
