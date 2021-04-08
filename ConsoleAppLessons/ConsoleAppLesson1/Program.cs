using System;

namespace ConsoleAppLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object, Dynamic, String and Custom data type is reference type

            //Console.WriteLine("Please Enter Your Name: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Hello " + userName + ", Have a good day!");

            //int newInt = 5;
            //Console.WriteLine(newInt);

            // Google string method

            //string phrase = "Giraffe Academy";
            //Console.WriteLine(phrase[7]);

            // ==================================================================

            // Simple calculator

            //Console.Write("Enter a number: ");
            //decimal num1 = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //decimal num2 = Convert.ToDecimal(Console.ReadLine());
            //decimal sum = num1 + num2;
            //Console.WriteLine("Sum of two numbers is: " + sum);

            // ==================================================================

            // Mad lib

            //string color, pluralNoun, celebrity;
            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();
            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();
            //Console.Write("Enter a celebrity name: ");
            //celebrity = Console.ReadLine();


            //Console.WriteLine("Rose are " + color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I love " + celebrity);

            //Console.ReadLine();

            // ==================================================================

            // Array

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //Console.WriteLine(luckyNumbers[0]); // search by index
            //Console.WriteLine(string.Join(" ,", luckyNumbers)); // print out all the items in array

            //luckyNumbers[3] = 900; // update value in array with index
            //Console.WriteLine(string.Join(" ,", luckyNumbers));

            //string[] friends = new string[5];
            //friends[0] = "Jim";
            //friends[1] = "Potter";
            //friends[2] = "Hank";
            //friends[3] = "Brad";
            //friends[4] = "Hans";

            //Console.WriteLine(string.Join(", ", friends));

            //Console.ReadLine();

            // ==================================================================

            // Methods

            //SayHi();
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            Console.ReadLine();
        }

        // Methods - generally perform a specific task (like function)
        static void SayHi()
        {
            Console.WriteLine("Hello");
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}