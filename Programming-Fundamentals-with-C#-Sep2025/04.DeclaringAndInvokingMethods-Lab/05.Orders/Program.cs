using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal sum = WhichItem(item) * quantity;

            Console.WriteLine($"{sum:f2}");




        }


        static decimal WhichItem(string item)
        {
            if (item == "coffee")
            {
                return 1.50m;
            }
            else if (item == "water")
            {
                return 1;
            }
            else if (item == "coke")
            {
                return 1.40m;
            }
            else if (item == "snacks")
            {
                return 2;
            }
            return 0;

        }
    }
}
