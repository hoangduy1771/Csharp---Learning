using System;

namespace ConsoleAppLesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                 {1, 2 },
                 {3, 4 },
                 {5, 6 }
            };

            Console.WriteLine(numberGrid[0, 0]);

            Console.ReadLine();
        }
    }
}
