using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            bool isSpecial = false;
            string answer = string.Empty;

            for (int i = 1; i <= num; i++)
            {
                while (counter != 0)
                {
                    if (counter % 5 == 0 || counter % 7 == 0 || counter % 11 == 0 || i % 5 == 0 || i % 7 == 0 || i % 11 == 0)
                    {
                        isSpecial = true;
                    }

                    if (isSpecial == true)
                    {
                        answer = "True";
                        break;
                    }
                    else if (isSpecial == false)
                    {
                        answer = "False";
                    }

                    counter = counter / 10;
                  
                }

                Console.WriteLine($"{i} -> {answer}");
                counter++;
            }
        }
    }
}
