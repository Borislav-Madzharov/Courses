using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            char first = 'a';
            char middle = 'a';
            char third = 'a';
            int conversionVar = (int)first;
            int conversionVar2 = (int)middle;
            int conversionVar3 = (int)third - 1;

            for (int i = 1; i <= count; i++)
            {
                
                for (int j = 1; j <= count; j++)
                {
                    for (int k = 1; k <= count; k++)
                    {
                        conversionVar3++;
                        Console.WriteLine($"{(char)conversionVar}{(char)conversionVar2}{(char)conversionVar3}");
                        
                    }
                    conversionVar3 = 96;
                    conversionVar2++;
                }
                conversionVar2 = 97;
                conversionVar++;
            }
            


        }
    }
}
