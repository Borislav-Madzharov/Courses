using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();
            string result = "";

            foreach (char c in chars)
            {
                result += (char)(c + 3);
            }
            Console.WriteLine(result);



        }
    }
}
