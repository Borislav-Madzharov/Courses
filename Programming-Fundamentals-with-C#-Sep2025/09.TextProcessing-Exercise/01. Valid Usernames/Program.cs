using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.None);
            List<string> output = new List<string>();
            bool valid = false;

            foreach (string user in input)
            {

                if (user.Length >= 3 && user.Length <= 16)
                {
                    foreach (char c in user)
                    {
                        if (c >= 48 && c <= 57 || c >= 65 && c <= 90 || c == 95 || c == 45 || c >= 97 && c <= 122)
                        {
                            valid = true;
                        }
                        else
                        {
                            valid = false;
                            break;
                        }
                    }

                    if (valid)
                    {
                        output.Add(user);
                    }


                }

            }


            foreach (string word in output)
            {
                Console.WriteLine(word);
            }


        }
    }
}
