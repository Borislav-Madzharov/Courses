using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
3
0 1
0 right 1
2 right 1
end

             */

            int[] field = new int[int.Parse(Console.ReadLine())];
            int[] startingLadybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string unconvertedInput = Console.ReadLine();

            for (int i = 0; i < startingLadybugs.Length; i++)
            {
                field[startingLadybugs[i]] = 1;
            }

            while (unconvertedInput != "end")
            {
                string[] convertedInput = unconvertedInput.Split();
                int whichLadyBug = int.Parse(convertedInput[0]);
                string directiom = convertedInput[1];
                int flyLength = int.Parse(convertedInput[2]);


                if (whichLadyBug >= 0 && whichLadyBug <= field.Length - 1 && field[whichLadyBug] == 1)
                {
                    if (directiom == "right")
                    {
                        int landIndex = whichLadyBug + flyLength;
                        while (landIndex <= field.Length - 1 && flyLength + field[whichLadyBug] >= 0 && field[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            break;
                        }
                        field[whichLadyBug] = 0;
                        if (landIndex >= 0 && landIndex <= field.Length - 1)
                        {
                            field[landIndex] = 1;
                        }
                        continue;
                    }
                    else if (directiom == "left")
                    {
                        int landIndex = whichLadyBug - flyLength;
                        while (landIndex <= field.Length - 1 && landIndex >= 0 && field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                        }
                        field[whichLadyBug] = 0;

                        if (landIndex >= 0 && landIndex <= field.Length - 1)
                        {
                            field[landIndex] = 1;
                        }
                        continue;
                    }
                }



                    unconvertedInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));





        }
    }
}
