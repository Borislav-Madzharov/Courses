using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//for (int j = (commandArr.Length / 2) + 1; j < commandArr.Length; j++)
//{
//    if (commandArr[i] != commandArr[j])
//    {
//        return false;
//    }
//}
//for (int j = commandArr.Length - 1; j > commandArr.Length / 2; j--)
//{
//    if (commandArr[i] != commandArr[j])
//    {
//        return false;
//    }
//    else
//    {
//        j--;
//        break;
//    }
//}
namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                char[] commandArr = command.ToCharArray();

                if (command.Length % 2 == 0)
                {
                    Console.WriteLine(EvenDigitPalindrome(commandArr));
                }
                else
                {
                    Console.WriteLine(OddDigitPalindrome(commandArr));
                }
            }


        }

        static bool EvenDigitPalindrome(char[] commandArr)
        {
            int counter = commandArr.Length - 1;
            for (int i = 0; i < commandArr.Length / 2; i++)
            {
                
                
                if (commandArr[i] != commandArr[counter])
                {
                    return false;
                }
                counter--;
            }
            return true;

        }
        static bool OddDigitPalindrome(char[] commandArr)
        {
            int counter = commandArr.Length - 1;
            for (int i = 0; i < commandArr.Length / 2; i++)
            {


                if (commandArr[i] != commandArr[counter])
                {
                    return false;
                }
                counter--;
            }
            return true;

        }


    }
}
