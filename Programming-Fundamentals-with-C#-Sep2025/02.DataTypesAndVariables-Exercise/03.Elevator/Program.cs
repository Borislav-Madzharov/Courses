using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine()); 
            int countOfCourses = totalPeople / capacityOfElevator;
            int extrapeople = totalPeople % capacityOfElevator;
            int sum = countOfCourses;

            while (extrapeople > 0)
            {
                extrapeople = extrapeople - capacityOfElevator;

                countOfCourses++;
            }


            Console.WriteLine(countOfCourses);


        }
    }
}
