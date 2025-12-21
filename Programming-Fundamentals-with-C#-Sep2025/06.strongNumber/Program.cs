using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.strongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            char specificChar;
            int factorial = 1;
            int digit;
            int sum = 0;
            bool equal = false;
            int startNum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                specificChar = input[i];
                digit = int.Parse(specificChar.ToString());

                if (digit == 0)
                {
                    continue;
                }



                for (int j = 1; j <= digit; j++)
                {
                    factorial *= j;
                    
                }
                
                sum += factorial;
                factorial = 1;

            }

            startNum = int.Parse(input.ToString());

            if (sum == startNum)
            {
                equal = true;
            }

            if (equal)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
