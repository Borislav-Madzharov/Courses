using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();
            bool can = false;
            int length = numbers.Count-1;
            int iniCount = numbers.Count;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i + 2 <= numbers.Count)
                {
                    if (i > 0)
                    {
                        if (numbers[i - 1] == numbers[i])
                        {
                            numbers[i - 1] += numbers[i];
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }


                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        i--;
                    }
                }
                
            }


            Console.WriteLine(string.Join(" ", numbers));




        }
    }
}
