using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            foreach (string firstElem in secondArray)
            {
                foreach (string secondElem in firstArray)
                {
                    if (firstElem == secondElem)
                    {
                        Console.Write($"{secondElem} ");
                    }
                }
            }



        }
    }
}
