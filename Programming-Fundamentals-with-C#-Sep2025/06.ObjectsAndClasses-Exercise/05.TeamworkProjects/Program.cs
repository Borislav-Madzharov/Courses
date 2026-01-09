using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clubsCount = int.Parse(Console.ReadLine());
            List<Club> clubs = new List<Club>();
            List<Person> persons = new List<Person>();

            string command = "";

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = Console.ReadLine().Split('-');
                string name = arguments[0];
                string team = arguments[arguments.Length - 1];



                if (arguments[2] != ">")
                {
                    Club club = new Club();
                    club.Name = team;
                    clubs.Add(club);
                    if (club.Creator == null)
                    {
                        club.Creator = name;
                    }
                    Person person = new Person();
                    person.Creator = true;
                    person.Name = name;
                    persons.Add(person);

                }
                else
                {
                    bool clubExists = false ;
                    int clubIndex = 0;
                    bool personDoesNotExists = false;
                    foreach (Club club in clubs)
                    {
                        if (team == club.Name)
                        {
                            clubExists = true;
                        }
                    }

                    foreach (Person person in persons)
                    {
                        if (name != person.Name)
                        {
                            personDoesNotExists = true;
                        }
                    }

                    if (clubExists == true && personDoesNotExists == true)
                    {
                        
                    }
                }







            }

           

             





        }
    }

    public class Club
    {
        public string Name;
        public List<string> MemberNames;
        public int Members;
        public string Creator;

    }
    public class Person
    {
        public string ClubStatus;
        public bool Creator;
        public string Name;


    }



}
