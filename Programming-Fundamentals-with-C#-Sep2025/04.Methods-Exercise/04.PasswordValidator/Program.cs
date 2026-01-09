using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();


            if (PasswordCharacters(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (PasswordLettersAndDigits(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits"); 
            }
            if (Password2Digits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                Console.WriteLine("Password is valid");
            }
       

        }
        
        static bool PasswordCharacters(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
        static bool PasswordLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 97 && password[i] <= 122 || password[i] >= 48 && password[i] <= 57 || password[i] >= 65 && password[i] <= 90)
                {

                }
                else
                {
                    return false;
                }

            }
            return true;

        }
        static bool Password2Digits(string password)
        {
            int digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digitCounter ++;
                }
            }

            if (digitCounter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
