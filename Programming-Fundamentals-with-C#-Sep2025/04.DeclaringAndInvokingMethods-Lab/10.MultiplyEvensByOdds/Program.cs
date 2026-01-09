using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string generalString = Console.ReadLine();
            int generalNum = int.Parse(generalString);
            if (generalNum < 0)
                {
                  generalNum = generalNum - 2 * generalNum;
                }
            int[] arrayNum = generalNum.ToString().Select(c => int.Parse(c.ToString())).ToArray();


            int sum1 = OddNumsSum(arrayNum);
            int sum2 = EvenNumsSum(arrayNum);

        
            Console.WriteLine(SumsMultiplier(sum1, sum2));
        }

        static int OddNumsSum(int[] arrayNum)
        {
            int oddSum = 0;
            for (int i = 0; i < arrayNum.Length; i++)
            {
                if (arrayNum[i] % 2 == 0)
                {
                    oddSum += arrayNum[i];
                }
            }
            return oddSum;
        }

        static int EvenNumsSum(int[] arrayNum)
        {
            int evenSum = 0;
            for (int i = 0; i < arrayNum.Length; i++)
            {
                if (arrayNum[i] % 2 != 0)
                {
                    evenSum += arrayNum[i];
                }
            }
            return evenSum;
        }

        static int SumsMultiplier(int sum1, int sum2)
        {
            
                return sum1 * sum2;
            
        }
    }
}
