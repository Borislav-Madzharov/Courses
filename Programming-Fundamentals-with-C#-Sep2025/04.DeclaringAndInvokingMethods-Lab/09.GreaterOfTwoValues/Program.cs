using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            ValueComparison(type, value1, value2);


        }

        static void ValueComparison(string type, string value1, string value2)
        {
            if (type == "int")
            {
                int num1 = int.Parse(value1);
                int num2 = int.Parse(value2);

                if (num1 > num2)
                {
                    Console.WriteLine(num1);
                }
                else if (num2 > num1) 
                {
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num1);
                }

            }
            else if (type == "char")
            {
                char char1 = char.Parse(value1);
                char char2 = char.Parse(value2);

                if ( char1 >  char2)
                {
                    Console.WriteLine(char1);
                }
                else if (char2 >  char1)
                {
                    Console.WriteLine(char2);
                }
                else
                {
                    Console.WriteLine(char1);
                }

            }
            else if (type == "string")
            {
                string string1 = (string)value1;
                string string2 = (string)value2;

                int result = string1.CompareTo(string2);
                if (result > 0)
                {
                    Console.WriteLine(string1);
                }
                else if (result < 0)
                {
                    Console.WriteLine(string2);
                }
                else
                {
                    Console.WriteLine(string1);
                }

            }
        }
    }
}
