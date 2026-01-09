using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(wordToRemove))
            {
                int startingIndex = word.IndexOf(wordToRemove);
                word = word.Remove(startingIndex, wordToRemove.Length);


            }

            Console.WriteLine(word);




        }
    }
}
