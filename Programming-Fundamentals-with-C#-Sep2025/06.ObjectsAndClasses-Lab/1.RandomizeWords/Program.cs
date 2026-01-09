using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomNum = rnd.Next(0, words.Length);

                string tempString = words[i];
                words[i] = words[randomNum];
                words[randomNum] = tempString;


            }


            Console.WriteLine(string.Join("\n", words));



        }
    }
}
