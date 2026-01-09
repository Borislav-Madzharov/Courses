using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int spices = 0;
            int days = 0;

            while (yield >= 100)
            {
                spices += yield;
                yield -= 10;
                spices -= 26;
                days++;

            }
            spices -= 26;
            if (spices < 0)
            {
                spices = 0;
            }


            Console.WriteLine(days);
            Console.WriteLine(spices);

        }
    }
}
