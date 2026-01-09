using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> iniNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ');
                if (command[0] == "Add")
                {
                    iniNums.Add((int.Parse(command[1])));
                }
                else if (command[0] == "Remove")
                {
                    iniNums.Remove(int.Parse(command[1]));
                }
                else if (command[0] == "RemoveAt")
                {
                    iniNums.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    iniNums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }


            }

            Console.WriteLine(string.Join(" ", iniNums));
            


        }

        static string IntAdd(string[] command, List<int> values)
        {
            


            return "";
        }
    }
}
