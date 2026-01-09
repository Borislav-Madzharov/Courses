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

            for (int i = 0; i < numbers.Length  - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentNum = numbers[i];
                    sequenceCounter++;
                }
                else
                {
                    sequenceCounter = 0;
                    continue;
                }
                if (sequenceCounter > highestSequence)
                {
                    highestSequence = sequenceCounter;
                    bestNum = currentNum;
                    firstSequence = true;
                }
                
            }

            for (int i = -1; i < highestSequence; i++)
            {
                Console.Write($"{bestNum} ");
            }
        }
    }
}
