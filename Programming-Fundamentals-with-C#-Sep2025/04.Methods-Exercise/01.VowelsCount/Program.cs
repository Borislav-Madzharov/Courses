using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] genericName = Console.ReadLine().ToCharArray();

            Console.WriteLine(VowelCounter(genericName));





        }

        static int VowelCounter(char[] genericName)
        {
            int counter = 0;
            for (int i = 0; i < genericName.Length; i++)
            {
                if (genericName[i] == 'a' || genericName[i] == 'A' || genericName[i] == 'e' || genericName[i] == 'E' || genericName[i] == 'i' || genericName[i] == 'I' || genericName[i] == 'o' || genericName[i] == 'O' || genericName[i] == 'u' || genericName[i] == 'U')
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}
