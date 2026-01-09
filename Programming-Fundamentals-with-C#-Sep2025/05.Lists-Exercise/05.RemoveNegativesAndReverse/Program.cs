using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool isPositive = false;

            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] < 0)
                {
                    ints.Remove(ints[i]);
                    i--;
                }
                else
                {
                    isPositive = true;
                }


            }
            ints.Reverse();

            if (isPositive == false)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", ints));
            }
            

        }
    }
}
