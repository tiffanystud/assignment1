using System;

namespace Review
{
    class Album
    {
        private string albumName;
        private string creatorName;
        private int nrTracks;

        public Album()
        {
            this.albumName = "Unknown";
            this.creatorName = "Unknown";
            this.nrTracks = 0;
        }

        public void Start()
        {
            ReadAndSaveAlbumData();
            DisplayAlbumInfo();
        }
        
        private void ReadAndSaveAlbumData()
        {
            Console.Write("Whats the name of your favorite music album? ");
            albumName = Console.ReadLine();

            Console.Write($"What's the artist or band name for the album {albumName}? ");
            creatorName = Console.ReadLine();

            Console.Write($"How many tracks does {albumName} have? ");
            nrTracks = int.Parse(Console.ReadLine());
        }

        private void DisplayAlbumInfo()
        {
            Console.WriteLine("                   ");
            Console.WriteLine("-------------------");
            Console.WriteLine("                   ");

            Console.WriteLine($"Album Name: {albumName} ");
            Console.WriteLine($"Artist/Band: {creatorName} ");
            Console.WriteLine($"Number of Tracks: {nrTracks} ");

            Console.WriteLine("                   ");
            Console.WriteLine("-------------------");
            Console.WriteLine("                   ");
        }

    }
}
