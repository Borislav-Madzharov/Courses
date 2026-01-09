using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Ivan Pishman 17 Pleven
Ivan Pishman 18 Pleven
Ivanka Pishmanka 16 Pleven
Siika Plamena 27 Pleven 
Ivan Pishman 20 Pleven
end
Pleven
 
 */

namespace _05.Students
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


                if (IsStudentExisting(students, input[0], input[1]))
                {
                    Student student = GetStudent(students, input[0], input[1]);

                    student.FirstName = input[0];
                    student.LastName = input[1];
                    student.Age = input[2];
                    student.HomeTown = input[3];


                }
                else
                {
                    Student student = new Student();

                    student.FirstName = input[0];
                    student.LastName = input[1];
                    student.Age = input[2];
                    student.HomeTown = input[3];

                    students.Add(student);
                }




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


         public static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {

            foreach (Student student in students)
            {
                if (firstName == student.FirstName && lastName == student.LastName)
                {
                    return true;
                }
            }



            return false;
        }
        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
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

