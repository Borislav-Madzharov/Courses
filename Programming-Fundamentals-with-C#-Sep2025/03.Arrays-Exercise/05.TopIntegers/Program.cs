using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 72 28 13 64 25 63 22
             */


            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] biggest = new int[3];
            biggest[2] = numbers[numbers.Length - 1];
            int counter = 0;
            int biggestCurrentNumber = int.MinValue;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (biggestCurrentNumber < numbers[j])
                    {
                        biggestCurrentNumber = numbers[j];
                    }

                    if (numbers[i] >= biggestCurrentNumber && j + 1 == numbers.Length)
                    {
                        biggest[counter] = numbers[i]; 
                        counter++;
                    }
                    else
                    {
                        continue;
                    }
                    biggestCurrentNumber = int.MinValue;
                    //if (j + 1 == numbers.Length && biggest[0] != 0)
                    //{
                    //    counter++;

                    //}
                }
            }

            
            if (biggest[0] == 0 && biggest[1] == 0)
            {
                Console.WriteLine(biggest[2]);
            }
            else if (biggest[0] == 0)
            {
                Console.Write(biggest[1]);
                Console.Write(" ");
                Console.Write(biggest[2]);
            }
            else if (biggest[1] == 0)
            {
                Console.Write(biggest[0]);
                Console.Write(" ");
                Console.Write(biggest[2]);
            }
            else
            {
                Console.WriteLine(string.Join(" ", biggest));
            }

        }
    }
}
