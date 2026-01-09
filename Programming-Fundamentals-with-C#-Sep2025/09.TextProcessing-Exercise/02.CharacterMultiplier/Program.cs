using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int sum = 0;

            string word1 = words[0];
            string word2 = words[1];

            sum = Sum(word1, word2);
            Console.WriteLine(sum);
        }
    

        public static int Sum(string word1, string word2)
        {
            int sum = 0;
            int maxLength = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < word1.Length && i < word2.Length)
                {
                    sum += word1[i] * word2[i];
                }
                else if (word1.Length > i)
                {
                    sum += word1[i];
                }
                else if (word2.Length > i)
                {
                    sum += word2[i];
                }
            }




            return sum;
        }
    }
}
