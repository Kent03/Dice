using System;

namespace song
{
    internal class Program
    {
        public string TypeList { get; set; }
        public string Name { get; set; }   
        public string Time { get; set; }    

        int numSongs= int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();
    }
}
