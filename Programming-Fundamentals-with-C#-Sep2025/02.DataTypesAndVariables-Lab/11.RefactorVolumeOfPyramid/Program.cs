using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, heigth = 0;
            double volume = 0;

            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());

            volume = (lenght * width * heigth) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");


        }
    }
}
