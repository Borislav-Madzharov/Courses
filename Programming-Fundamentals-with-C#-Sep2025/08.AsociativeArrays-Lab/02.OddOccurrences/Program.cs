using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym  = Console.ReadLine();


                if (synonyms.ContainsKey(word) == false)
                {
                    synonyms.Add(word, new List<string>());
                }
                synonyms[word].Add(synonym);

            }




            foreach ((string word, List<string> words) in synonyms)
            {

                Console.WriteLine($"{word} - {string.Join(", ", words)}");
            }

        }
    }
}
