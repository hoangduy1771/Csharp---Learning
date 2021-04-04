using System;

namespace ConsoleAppLesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception
            try
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result: " + num1 / num2);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


            Console.ReadLine();
        }

    }
}
