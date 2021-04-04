using System;

namespace ConsoleAppLesson10_GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Avengers Endgame", "The Russo", "PG"); 
            Movie movie2 = new Movie("Thor: Ragnarok", "Taika Waititi", "G");
            // G, PG, PG-13, R, NR

            movie2.Rating = "";
            Console.WriteLine(movie1.Rating);
            Console.WriteLine(movie2.Rating);

            Console.ReadLine();

        }
    }
}
