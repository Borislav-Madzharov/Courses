using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            int rememberCount = 0;
            bool isTrue = false;
            for (int num = 1; num <= count; num++)
            {
                rememberCount = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                isTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", rememberCount, isTrue);
                sum = 0;
                num = rememberCount;
            }


        }
    }
}
