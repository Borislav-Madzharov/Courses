using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int initialCount = ints.Count;

            for (int i = 0; i < initialCount / 2; i++)
            {
                ints[i] += ints[ints.Count - 1];
                ints.RemoveAt(ints.Count - 1);

            }

            Console.WriteLine(string.Join(" ", ints));



        }
    }
}
