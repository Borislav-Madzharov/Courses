using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            CharsInRange(firstChar, secondChar);


        }

        static void CharsInRange(char firstChar, char secondChar)
        {
            int charInNum1 = firstChar;
            int charInNum2 = secondChar;
            int tempnum = 0;

            if (charInNum2 < charInNum1)
            {
                tempnum = charInNum2;
                charInNum2 = charInNum1;
                charInNum1 = tempnum;
            }


            for (int i = charInNum1 + 1; i < charInNum2; i++)
            {
                Console.Write($"{(char)i} ");
            }

        }
    }
}
