using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for ( int i = 0; i < count; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }



        }
    }
}
