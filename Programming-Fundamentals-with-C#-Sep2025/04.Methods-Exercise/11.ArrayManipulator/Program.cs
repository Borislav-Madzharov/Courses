using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1 2 3 4 5
exchange 2

1 2 3 4 5
min even


1 8 2 3
first 2 even


1 3 5 7 9
exchange 1
max odd
min even
first 2 odd
last 2 even
exchange 3
end

 */



namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initalNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string command;
            string emptyString;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(' ');
                if (input[0] == "exchange" && int.Parse(input[1]) <= initalNums.Length - 1 )
                {
                    initalNums = ExchangeOperation(input, initalNums);
                    continue;
                }
                else if (input[0] == "max" && (input[1] == "even" || input[1] == "odd") )
                {
                    emptyString = MaxOddEven(initalNums, input);
                    continue;
                }
                else if (input[0] == "min" && (input[1] == "even" || input[1] == "odd"))
                {
                    emptyString = MinOddEven(initalNums, input);
                    continue;
                }
                else if (input[0] == "first" && int.Parse(input[1]) != 100000 && (input[2] == "even" || input[2] == "odd"))
                {
                    FirstEvenOdd(initalNums, input);
                    continue;
                }
                else if (input[0] == "last" && int.Parse(input[1]) != 100000 && (input[2] == "even" || input[2] == "odd"))
                {
                    emptyString = LastEvenOdd(initalNums, input);
                    continue;
                }

            }


            Console.Write("[");
            for (int i = 0; i < initalNums.Length; i++)
            {
                Console.Write($"{initalNums[i]}");
                
                if (i + 1 != initalNums.Length)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        
        }

        static int[] ExchangeOperation(string[] input, int[] nums)
        {
            int index = int.Parse(input[1]);
            int[] arr1 = new int[index + 1];
            int[] arr2 = new int[nums.Length - index - 1];
            int[] afterArr = new int[nums.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                afterArr[i + arr1.Length - 1] = nums[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                afterArr[i] = nums[i + arr1.Length];
            }
            return afterArr.ToArray();
        }
        static string MaxOddEven(int[] nums,  string[] input)
        {
            if (input[1] == "odd")
            {
                int maxOdd = 0;
                int maxOddIndex = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] >= maxOdd && nums[i] % 2 != 0)
                    {
                        maxOdd = nums[i];
                        maxOddIndex = i;
                    }
                }
                Console.WriteLine(maxOddIndex);
                maxOddIndex = 0;
                maxOdd = 0;

            }
            else if (input[1] == "even")
            {
                int maxEven = 0;
                int maxEvenIndex = 0;
                
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] >= maxEven && nums[i] % 2 == 0)
                    {
                        maxEven = nums[i];
                        maxEvenIndex = i;
                    }
                }
                Console.WriteLine(maxEvenIndex);
                maxEvenIndex = 0;
                maxEven = 0;

            }
            else
            {
                Console.WriteLine("No matches");
            }

                return "";
        }
        static string MinOddEven(int[] nums, string[] input)
        {
            

            if (input[1] == "odd")
            {
                int minOdd = 10000000;
                int minOddIndex = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] >= minOdd && nums[i] % 2 != 0 || (minOddIndex > i && nums[i] >= minOdd && nums[i] % 2 != 0))
                    {
                        minOdd = nums[i];
                        minOddIndex = i;
                    }
                }
                Console.WriteLine(minOddIndex);
                minOddIndex = 0;
                minOdd = 0;

            }
            else if (input[1] == "even")
            {
                int minEven = 100000000;
                int minEvenIndex = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] <= minEven && nums[i] % 2 == 0 || (minEvenIndex > i && nums[i] >= minEven && nums[i] % 2 != 0))
                    {
                        minEven = nums[i];
                        minEvenIndex = i;
                    }
                }
                Console.WriteLine(minEvenIndex);
                minEvenIndex = 0;
                minEven = 0;

            }
            else
            {
                Console.WriteLine("No matches");
            }

            return "";
        }
        static string FirstEvenOdd(int[] nums, string[] input)
        {
            if (int.Parse(input[1]) > nums.Length)
            {
                Console.WriteLine("Invalid count");
                return "";
            }

            int[] currentArr = new int[int.Parse(input[1])];
            int arrCounter = 0;
            bool areThereElems = false;

            if (input[2] == "odd")
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (arrCounter == currentArr.Length)
                    {
                        break;
                    }
                    if (nums[i] % 2 != 0)
                    {
                        currentArr[arrCounter] = nums[i];
                        arrCounter++;
                        areThereElems = true;
                    }

                }
            }
            else if (input[2] == "even")
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (arrCounter == currentArr.Length)
                    {
                        break;
                    }
                    if (nums[i] % 2 == 0)
                    {
                        currentArr[arrCounter] = nums[i];
                        arrCounter++;
                        areThereElems = true;
                    }

                }
            }
            if (areThereElems = true)
            {
                Console.Write("[");
                for (int i = 0; i < currentArr.Length; i++)
                {

                    if (currentArr[i] != 0)
                    {
                        Console.Write($"{currentArr[i]}");
                    }
                    else
                    {
                        continue;
                    }

                    if (i + 1 != currentArr.Length)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }
            else
            {
                Console.WriteLine("[]");
            }
            return "";
        }
        static string LastEvenOdd(int[] nums, string[] input)
        {
            if (int.Parse(input[1]) > nums.Length)
            {
                Console.WriteLine("Invalid count");
                return "";
            }

            int[] currentArr = new int[int.Parse(input[1])];
            int arrCounter = currentArr.Length - 1;
            bool areThereElems = false;

            if (input[2] == "odd")
            { 
                for (int i = currentArr.Length - 1; i >= 0; i--)
                {
                    if (nums[i] % 2 != 0)
                    {
                        currentArr[arrCounter] = nums[i];
                        arrCounter--;
                        areThereElems = true;
                    }
                    if (arrCounter == 0)
                    {
                        break;
                    }
                }
            }
            else if (input[2] == "even")
            {
                for (int i = currentArr.Length - 1; i >= 0; i--)
                {
                    if (nums[i] % 2 == 0)
                    {
                        currentArr[arrCounter] = nums[i];
                        arrCounter--;
                        areThereElems = true;
                    }
                    if (arrCounter == 0)
                    {
                        break;
                    }
                }
            }

            if (areThereElems = true)
            {
                Console.Write("[");
                for (int i = 0; i < currentArr.Length; i++)
                {

                    if (currentArr[i] != 0)
                    {
                        Console.Write($"{currentArr[i]}");
                    }
                    else
                    {
                        continue;
                    }

                    if (i + 1 != currentArr.Length)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }
            else
            {
                Console.WriteLine("[]");
            }

                return "";
        }
    }
}
