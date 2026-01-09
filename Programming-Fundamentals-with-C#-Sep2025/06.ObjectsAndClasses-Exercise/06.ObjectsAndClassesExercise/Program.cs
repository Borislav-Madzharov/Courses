using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ObjectsAndClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ads = int.Parse(Console.ReadLine());
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };


            Random rand = new Random();

            for (int i = 0; i < ads; i++)
            {
                int randomPhrase = rand.Next(phrases.Length);
                int randomEvent = rand.Next(events.Length);
                int randomAuthor = rand.Next(authors.Length);
                int randomCities = rand.Next(cities.Length);

                Console.WriteLine($"{phrases[randomPhrase]} {events[randomEvent]} {authors[randomAuthor]} – {cities[randomCities]}.");





            }




        }
    }



}
