using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseStrings
{


    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string word = command;

                words.Add(word);
            }

            foreach (string word in words)
            {
                Console.WriteLine($"{word} = {ReverseString(word)}");
            }



        }

        public static string ReverseString(string text)
        {
            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            return reversed;
        }





    } 

}


