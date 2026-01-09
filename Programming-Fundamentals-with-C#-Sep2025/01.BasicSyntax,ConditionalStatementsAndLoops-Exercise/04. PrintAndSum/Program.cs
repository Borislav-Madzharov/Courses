using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endtNum = int.Parse(Console.ReadLine());

            int sum = startNum;
            int counter = 0;

            for (int i = startNum + 1; i <= endtNum; i++)
            {
                sum += i;
            }
            for (int i = startNum + 1; i <= endtNum + 1; i++)
            {
                Console.Write($"{startNum + counter} ");
                counter++;
            }
            Console.WriteLine("");
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
