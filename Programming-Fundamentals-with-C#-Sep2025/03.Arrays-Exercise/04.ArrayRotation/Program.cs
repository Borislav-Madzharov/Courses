using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int lastRotations = rotations % array.Length;
            int[] rotatedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                rotatedArray[i] = array[(i + lastRotations) % array.Length];
            }

            Console.WriteLine(string.Join(" ", rotatedArray));

        }
    }
}
