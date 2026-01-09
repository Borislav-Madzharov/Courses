using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                int currentWagon = int.Parse(Console.ReadLine());
                people[i] = currentWagon;
                sum += currentWagon;

                

            }
            System.Console.WriteLine(String.Join(" ", people));
            Console.WriteLine(sum);



        }
    }
}
