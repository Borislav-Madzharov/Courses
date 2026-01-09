using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Arrays_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (num <= 7 && num > 0)
            {
                Console.WriteLine(days[num - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            



        }
    }
}
