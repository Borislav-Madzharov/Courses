using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> finalList = new List<int>();

            int smallestLength = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < smallestLength; i++)
            {

                if (firstList.Count > i)
                {
                    finalList.Add(firstList[i]);
                }
                if (secondList.Count > i)
                {
                    finalList.Add(secondList[i]);
                }
            }


            Console.WriteLine(string.Join(" ", finalList));

        }
    }
}
