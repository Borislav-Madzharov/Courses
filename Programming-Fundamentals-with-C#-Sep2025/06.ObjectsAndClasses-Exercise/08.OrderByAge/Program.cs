using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
George 1024 12
George 1024 13
End
 
 */
namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonIdentification> People = new List<PersonIdentification>();
            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                string[] data = command.Split(' ');
                string firstName = data[0];
                string ID = data[1];
                string age = data[2];
                if (People.Find(p => p.Id == ID) != null)
                {
                    int index = People.FindIndex((p => p.Id == ID));

                    People[index].FirstName = firstName;
                    People[index].Age = int.Parse(age);
                }
                else
                {
                    PersonIdentification person = new PersonIdentification();
                    person.FirstName = firstName;
                    person.Age = int.Parse(age);
                    person.Id = ID;
                    People.Add(person);

                }



            }

            var sorted = People.OrderBy(x => x.Age).ToList();


            foreach (PersonIdentification person in sorted)
            {
                Console.WriteLine($"{person.FirstName} with ID: {person.Id} is {person.Age} years old.");
            }






        }
    }
    public class PersonIdentification
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}
