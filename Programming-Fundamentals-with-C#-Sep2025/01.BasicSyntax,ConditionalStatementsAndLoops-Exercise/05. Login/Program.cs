using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string user = Console.ReadLine();
            char[] pass = user.ToCharArray();
            int tries = 0;
            bool operationDone = false;

            Array.Reverse(pass);

            string reversePass = new string(pass);

            for (int i = 1; i < 5; i++)
            {
                tries++;
                string input = Console.ReadLine();
                if (input == reversePass)
                {
                    Console.WriteLine($"User {user} logged in.");
                    operationDone = true;
                    break;
                }
                else
                {
                    if (tries == 4)
                    {
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }


            }

            if (operationDone == false || tries == 4)
            {
                Console.WriteLine($"User {user} blocked!");
            }
        }
    }
}
