using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }


        static void Main(string[] args)
        {
            int songsCounter = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < songsCounter; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                string type = data[0];
                string name = data[1];
                string time = data[2];
                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                songs.Add(song);
            }
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }



            List<Song> filteredSongs = songs.Where(x => x.TypeList == typeList).ToList();
            foreach (Song song in filteredSongs)
            {
                Console.WriteLine(song.Name);

            }
        }
    }
}


        
    


