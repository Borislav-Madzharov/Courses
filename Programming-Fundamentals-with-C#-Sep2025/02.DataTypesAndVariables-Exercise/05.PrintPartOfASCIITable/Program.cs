using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());
            char currentChar = ' ' ;

            for (int i = startChar; i < endChar; i++)
            {
                currentChar = (char)startChar;

                Console.Write($"{currentChar} ");
                startChar++;
            }
            currentChar++;
            Console.Write($"{currentChar} ");
           
        }
    }
}
