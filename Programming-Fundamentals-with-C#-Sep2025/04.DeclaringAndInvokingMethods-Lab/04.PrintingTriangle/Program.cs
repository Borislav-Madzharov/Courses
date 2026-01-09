using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                FirstHalf(1, i);
            }

            for (int i = count - 1; i >= 0; i--)
            {
                FirstHalf(1, i);
            }


        }

        static void FirstHalf(int start,int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write( i + " ");

            }
            Console.WriteLine();

        }

        static void SecondHalf(int start,int end)
        {
            for (int i = 1; i <= end; end--)
            {
                Console.Write(end + " ");

            }
            Console.WriteLine();
        }

    }
}
