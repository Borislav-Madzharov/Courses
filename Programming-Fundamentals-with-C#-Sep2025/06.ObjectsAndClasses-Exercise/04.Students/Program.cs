using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
4
Lakia Eason 3,90
Prince Messing 5,49
Akiko Segers 4,85
Rocco Erben 6,00

 
 */


namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            string[] studentInfo;
            for (int i = 0; i < studentCount; i++)
            {
                studentInfo = Console.ReadLine().Split();

                Student student = new Student();

                student.FirstName = studentInfo[0];
                student.LastName = studentInfo[1];
                student.Grade = studentInfo[2];
                students.Add(student);

            }

            students.Sort((x,y) => y.Grade.CompareTo(x.Grade));

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }



        }
    }

    public class Student
    {
        public string FirstName;
        public string LastName;
        public string Grade;

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}";
        }
    }


}
