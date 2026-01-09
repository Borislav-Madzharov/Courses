using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsToBan = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            string text = Console.ReadLine();


            foreach (string banned in wordsToBan)
            {
                string replacement = new string('*', banned.Length);
                text = text.Replace(banned, replacement);
            }
            Console.WriteLine(text);

        }
    }
}
