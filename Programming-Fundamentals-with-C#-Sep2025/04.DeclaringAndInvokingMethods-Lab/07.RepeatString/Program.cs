using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            string theNewWord = WordMultiplier(word, multiplier);

            Console.WriteLine(theNewWord);



        }

        static string WordMultiplier(string word, int multiplier)
        {
            string[] unconnectedString = new string[multiplier];
            for (int i = 0; i < multiplier; i++)
            {
                unconnectedString[i] = word;
            }
            string finalString = String.Join("",unconnectedString);
            return finalString;
        }
    }
}
