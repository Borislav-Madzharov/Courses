using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int explosionStrength = 0;
            List<char> result = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '>')
                {
                    result.Add(currentChar);
                    explosionStrength += input[i + 1] - '0'; // next char is a digit
                }
                else
                {
                    if (explosionStrength > 0)
                    {
                        explosionStrength--; // skip this char
                    }
                    else
                    {
                        result.Add(currentChar);
                    }
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}