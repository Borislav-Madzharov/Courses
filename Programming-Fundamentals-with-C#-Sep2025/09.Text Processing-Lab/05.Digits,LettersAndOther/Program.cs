using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();

            string digits = "";
            string words = "";
            string symbols = "";

            foreach (char c in chars)
            {
                if (char.IsDigit(c))
                {
                    digits += c;
                }
                else if (char.IsLetter(c))
                {
                    words += c;
                }
                else
                {
                    symbols += c;
                }
            }


            Console.WriteLine(digits);
            Console.WriteLine(words);
            Console.WriteLine(symbols);






        }
    }
}
