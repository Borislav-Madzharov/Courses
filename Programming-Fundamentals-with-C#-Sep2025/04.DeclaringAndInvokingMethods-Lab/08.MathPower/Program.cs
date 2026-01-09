using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(PowerCalculation(Base, power));



        }

        static double PowerCalculation(double Base,  double power)
        {
            double finalNum = Math.Pow(Base, power);
            return finalNum;

        }
    }
}
