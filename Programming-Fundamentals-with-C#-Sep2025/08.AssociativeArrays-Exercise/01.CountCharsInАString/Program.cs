using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountCharsInАString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            char[] text = Console.ReadLine().ToArray();

            foreach (char c in text)
            {
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 0);
                }
                dic[c]++;

            }

            foreach ( var c in dic)
            {
                if (c.Key != ' ')
                {
                    Console.WriteLine($"{c.Key} -> {c.Value}");
                }
            }








        }
    }
}
