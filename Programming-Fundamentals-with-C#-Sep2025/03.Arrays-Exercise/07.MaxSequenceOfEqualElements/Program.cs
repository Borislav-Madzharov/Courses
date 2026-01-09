using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sequenceCounter = 0;
            bool firstSequence = false;
            int currentNum = 0;
            int highestSequence = 0;
            int bestNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentNum = numbers[i];
                        sequenceCounter++;
                    }
                    else
                    {
                        break;
                    }
                    if (sequenceCounter > highestSequence)
                    {
                        highestSequence = sequenceCounter;
                        bestNum = currentNum;
                        firstSequence = true;
                    }

                }
                if (firstSequence == true && highestSequence > sequenceCounter)
                {
                    for (int q = 0; q < highestSequence; q++)
                    {
                        Console.Write(bestNum);
                        break;
                    }
                }
                sequenceCounter = 0;
            }





        }
    }
}
