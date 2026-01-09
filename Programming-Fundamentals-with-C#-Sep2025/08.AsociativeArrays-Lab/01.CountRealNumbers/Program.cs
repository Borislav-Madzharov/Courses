using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, int> counts = new SortedDictionary<string, int>();

            string[] ints = Console.ReadLine().Split(' ').ToArray();

            foreach (string num in ints)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts.Add(num, 1);
                }
            }

            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }


        }
    }
}
