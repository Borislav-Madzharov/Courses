using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//
//aabbac
namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> chars = Console.ReadLine().ToList();

            for (int i = 0; i < chars.Count - 1; i++)
            {
                if (chars[i] == chars[i +1])
                {
                    chars.RemoveAt(i);
                    i--;

                }
            }

            Console.WriteLine(string.Join("", chars));






        }
    }
}
