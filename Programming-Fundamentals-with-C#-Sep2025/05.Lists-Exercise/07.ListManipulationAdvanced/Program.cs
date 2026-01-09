using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input;
            bool isChanged = false;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ');

                if (command[0] == "Contains")
                {
                    Contains(int.Parse(command[1]), nums);
                }
                else if (command[0] == "PrintEven")
                {
                    PrintEven(nums);
                }
                else if (command[0] == "PrintOdd")
                {
                    PrintOdd(nums);
                }
                else if (command[0] == "GetSum")
                {
                    PrintSum(nums);
                }
                else if (command[0] == "Filter")
                {
                    Filter(nums, command[1], int.Parse(command[2]));
                }
                else if (command[0] == "Add")
                {
                     nums.Add((int.Parse(command[1])));
                    isChanged = true;
                }
                else if (command[0] == "Remove")
                {
                    nums.Remove(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    nums.RemoveAt(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Insert")
                {
                    nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    isChanged = true;
                }


            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }

        static string Contains(int specialNum, List<int> nums)
        {
            bool contains = false;
            foreach (int num in nums)
            {
                if (num == specialNum)
                {
                    contains = true;
                    break;
                }
            }
            if (contains)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
            return "";

        }
        static string PrintEven(List<int> nums)
        {
            List<int> even = new List<int>();
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    even.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", even));

            return "";
        }
        static string PrintOdd(List<int> nums)
        {
            List<int> odd = new List<int>();
            foreach (int num in nums)
            {
                if (num % 2 != 0)
                {
                    odd.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", odd));

            return "";
        }
        static string PrintSum(List<int> nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);

            return "";
        }
        static string Filter(List<int> nums, string operation, int specialNum)
        {
            List<int> filterNums = new List<int>();
            if (operation == "<")
            {

                foreach (int num in nums)
                {
                    if (num < specialNum)
                    {
                        filterNums.Add(num);
                    }
                }
            }
            else if (operation == ">")
            {

                foreach (int num in nums)
                {
                    if (num > specialNum)
                    {
                        filterNums.Add(num);
                    }
                }
            }
            else if (operation == ">=")
            {

                foreach (int num in nums)
                {
                    if (num >= specialNum)
                    {
                        filterNums.Add(num);
                    }
                }
            }
            else if (operation == "<=")
            {

                foreach (int num in nums)
                {
                    if (num <= specialNum)
                    {
                        filterNums.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", filterNums));

            return "";
        }

    }
}
