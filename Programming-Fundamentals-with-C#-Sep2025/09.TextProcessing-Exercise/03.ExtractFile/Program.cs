using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] file = Console.ReadLine().Split('\\', '.');

            string filePath = file[file.Length - 2];
            string fileExtension = file[file.Length - 1];

            Console.WriteLine($"File name: {filePath}");
            Console.WriteLine($"File extension: {fileExtension}");




        }
    }
}
