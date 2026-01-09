using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
Mitko, Sasho, Nqkoi, Nz
BlackList Me
BLacklist Sasho
 

Mike, John, Eddie
Blacklist Mike
Error 0
Report


 
 */


namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            int blacklistedNames = 0;
            int errorNames = 0;
            int totalErrorNames = 0;
            int totalBlacklistedNames = 0;

            string command = "";

            while ((command = Console.ReadLine()) != "Report")
            {
                string[] input = command.Split();
                if (input[0] == "Blacklist")
                {
                    blacklistedNames += Blacklist(names, input[1], blacklistedNames);
                }
                else if (input[0] == "Error")
                {
                    errorNames += Error(names, int.Parse(input[1]), errorNames);
                }
                else if (input[0] == "Change")
                {
                    Change(names, int.Parse(input[1]), input[2]);
                }

                totalErrorNames += errorNames;
                totalBlacklistedNames += blacklistedNames;

            }
            Console.WriteLine($"Blacklisted names: {blacklistedNames}");
            Console.WriteLine($"Lost names: {errorNames}");
            Console.WriteLine(string.Join(" ", names));


        }

        static int Blacklist(List<string> names,  string specialName, int blacklistedNames)
        {

            if (names.Contains(specialName) )
            {
                Console.WriteLine($"{specialName} was blacklisted.");
                names[names.IndexOf(specialName)] = "Blacklisted";
                return 1;
            }
            else
            {
                Console.WriteLine($"{specialName} was not found.");
                return 0;
            }
        }
        static int Error(List<string> names, int index, int errorNames)
        {
            if (index >= 0 && index < names.Count && names[index] != "Blacklisted" && names[index] != "Lost")
            {
                Console.WriteLine($"{names[index]} was lost due to an error.");
                names[index] = "Lost";
                return 1;
            }
            return 0;


        }
        static string Change(List<string> names, int index, string newName)
        {
            if (index >= 0 && index < names.Count)
            {   
                Console.WriteLine($"{names[index]} changed his username to {newName}.");
                names[index] = newName;
            }

            return "";
        }



    }
}
