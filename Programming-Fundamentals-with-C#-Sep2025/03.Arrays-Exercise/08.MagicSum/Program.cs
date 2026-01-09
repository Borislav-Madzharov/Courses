using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               20 14 13 10 27 16 20
               40
             */


            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int specialNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == specialNum)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }
                }


            }






        }
    }
}
