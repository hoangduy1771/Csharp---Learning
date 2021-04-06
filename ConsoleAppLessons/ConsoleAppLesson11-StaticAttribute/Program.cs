using System;

namespace ConsoleAppLesson11_StaticAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("21 Guns", "Green Day", 200);
            Song song2 = new Song("Only When It Rains", "Astrid S", 250);

            Console.WriteLine(song1.title);
            Console.WriteLine(song2.title);


            Console.ReadLine();
        }
    }
}
