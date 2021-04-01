using System;

namespace ConsoleAppLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement
            //bool isMale = true;

            //if (isMale)
            //{
            //    Console.WriteLine("You're Male");
            //} else
            //{
            //    Console.WriteLine("You're Not Male");
            //}



            // ====================================================================================

            // Tenary

            //Console.Write("Enter a number: ");
            //int inputNumber = Convert.ToInt32(Console.ReadLine());

            //string result = (inputNumber > 0) ? "Your Number Is Greater Than 0" : "Your Number Is Less Than 0";
            //Console.WriteLine(result);

            //Console.ReadLine();


            // ======================================================================================
            // Loops

            //int i = 1;
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // If statements



            Console.WriteLine("Enter the First Number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The greater number is: " + GetMax(firstNum, secondNum));

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else if (num1 < num2)
            {
                result = num2;
            }
            else
            {
                Console.WriteLine("Numbers are equal");
                result = 0;
            }


            return result;
        }
    }
}
