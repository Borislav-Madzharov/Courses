using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _01_1.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {//•	0-2 – baby
//•	3 - 13 – child
//•	14 - 19 – teenager
//•	20 - 65 – adult
//•	>= 66 – elder


            int age = int.Parse(Console.ReadLine());
            string status = string.Empty;


            if (0 <= age && 2 >= age)
            {
                status = "baby";
            }
            else if (3 <= age && 13 >= age)
            {
                status = "child";
            }
            else if (14 <= age && 19 >= age)
            {
                status = "teenager";
            }
            else if (20 <= age && 65 >= age)
            {
                status = "adult";
            }
            else if (66 <= age)
            {
                status = "elder";
            }

            Console.WriteLine(status);
        }
    }
}
