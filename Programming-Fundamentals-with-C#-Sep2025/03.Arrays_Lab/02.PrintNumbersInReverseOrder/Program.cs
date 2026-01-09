using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];


            for (int i = count - 1; i >= 0; i--)
            {
                numbers[i] = int.Parse(Console.ReadLine());


            }
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }





        }
    }
}
