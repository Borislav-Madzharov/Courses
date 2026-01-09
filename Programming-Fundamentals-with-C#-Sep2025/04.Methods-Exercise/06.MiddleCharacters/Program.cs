using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();

            if (word.Length % 2 == 0)
            {
                Console.Write(SecondOddMiddeCharacters(chars, word));
                Console.Write(OddMiddeCharacters(chars, word));

            }
            else
            {
                Console.WriteLine(EvenMiddleCharacters(chars, word));
            }

        }

        static string OddMiddeCharacters(char[] word, string actualWord)
        {
            int length = word.Length;
            return word[word.Length / 2  ].ToString();

        }
        static string SecondOddMiddeCharacters(char[] word, string actualWord)
        {
            int length = word.Length;
            return word[word.Length / 2 - 1].ToString();

        }
        static string EvenMiddleCharacters(char[] word, string actualWord)
        {
            int length = word.Length;
            return word[word.Length / 2].ToString();

        }


    }
}
