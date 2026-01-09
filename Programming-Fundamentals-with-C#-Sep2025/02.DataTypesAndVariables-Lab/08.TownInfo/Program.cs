using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            string population = Console.ReadLine();
            string area = Console.ReadLine();

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
