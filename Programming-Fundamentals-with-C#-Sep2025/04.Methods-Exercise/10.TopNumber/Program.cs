using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            decimal sum = 0;
            bool doesOdd = false;
            int lastNum = 1;

            for (int i = lastNum; i <= end; i++)
            {
                decimal[] digtits = new decimal[i.ToString().Length];
                int currentNum = i;

                for (int j = 0; j < digtits.Length; j++)
                {
                    digtits[j] = currentNum % 10;
                    currentNum /= 10;

                    sum += digtits[j];

                    if (digtits[j] % 2 != 0)
                    {
                        doesOdd = true;
                    }

                    if (sum % 8 == 0 && doesOdd && j == digtits.Length - 1)
                    {
                        lastNum = i;
                        Console.WriteLine(lastNum);
                    }

                }
                doesOdd = false;
                sum = 0;
            }


        }
    }
}
