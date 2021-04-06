using System;

namespace ConsoleAppLesson11_StaticAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("21 Guns", "Green Day", 200);
            Console.WriteLine(song1.getSongCount());
            //Console.WriteLine(Song.songCount);
            Song song2 = new Song("Only When It Rains", "Astrid S", 250);
            //Console.WriteLine(Song.songCount);

            // in order to access Static attribute we have to acess it from class
            //Console.WriteLine(Song.songCount);

            // access static attribute through object
            Console.WriteLine(song2.getSongCount());

            //Console.WriteLine(song1.title);
            //Console.WriteLine(song2.title);


            Console.ReadLine();
        }
    }
}
