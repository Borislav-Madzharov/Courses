using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2
favorite_Heaven can wait_2:11
later_505_1:36
all
 
 */



namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            List<string> types = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string[] commands = Console.ReadLine().Split('_');


                string type = commands[0];
                string name = commands[1];
                string time = commands[2];

                types.Add(type);


                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);

            }

            string whatToPrint = Console.ReadLine();


            if (whatToPrint == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == whatToPrint)
                    {
                        Console.WriteLine(song.Name);
                    }

                }
            }









        }
    }




    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
