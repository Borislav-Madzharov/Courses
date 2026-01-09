using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                int random = rnd.Next(0, 100);

                Console.WriteLine(random);
            }




        }
    }
}
