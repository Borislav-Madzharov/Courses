using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            char character;
            int value = 0;
            int sum = 0;

            for (int i = 1; i <= count; i++)
            {
                character = char.Parse(Console.ReadLine());
                value = (int)character;
                sum = sum + value;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
