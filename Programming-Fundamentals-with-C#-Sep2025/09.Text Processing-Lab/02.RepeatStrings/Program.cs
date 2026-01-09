using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            string result = null;

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }

            }

            Console.WriteLine(result);




        }
    }
}
