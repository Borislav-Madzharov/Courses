using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split();

               Student student = new Student();

                student.FirstName = input[0];
                student.LastName = input[1];
                student.Age = input[2];
                student.HomeTown = input[3];

                students.Add(student);



            }

            string WhichCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == WhichCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }



        }




        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
