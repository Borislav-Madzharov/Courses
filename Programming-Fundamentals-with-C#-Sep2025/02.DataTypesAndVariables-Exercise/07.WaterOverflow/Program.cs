using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int liters = 0;
            int max = 255;
            int sum = 0;


            for (int i = 1; i <= count; i++)
            {

                liters = int.Parse(Console.ReadLine());
                sum += liters;

                if (sum > max)
                {
                    sum = sum - liters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sum);
        }
    }
}
