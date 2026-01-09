using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());

            for (int i = 0; i < Num; i++)
            {
                Console.Write($"{Heigth(Num)} ");
                for (int j = 1; j < Num; j++)
                {
                    Console.Write($"{Width(Num)} ");
                }
                Console.WriteLine();
            }


        }

        static int Heigth(int num)
        {
            return num;
        }
        static int Width(int num)
        {
            return num;
        }
    }
}
