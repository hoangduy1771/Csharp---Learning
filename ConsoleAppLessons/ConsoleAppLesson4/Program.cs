using System;

namespace ConsoleAppLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loops

            //int index = 0;
            //while (index <= 20)
            //{
            //    if (index >= 5 && index <= 10)
            //    {
            //        index++;
            //        continue;
            //    }

            //    Console.WriteLine(index);
            //    index++;
            //}

            // =======================================================================

            // Guessing game - loops

            //string secretWord = "rhinos";
            //string guess = "";

            //while (guess != secretWord)
            //{
            //    Console.Write("Enter guess: ");
            //    guess = Console.ReadLine();

            //}
            //Console.Write("You Win!");


            //Console.ReadLine();

            // ========================================================================

            // Collection

            // List
            List<string> MyList = new List<string>();
            MyList.Add("Cars");
            MyList.Add("Plane");

            foreach (string item in MyList)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();


        }
    }
}
