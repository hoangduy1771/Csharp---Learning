using System;

namespace ConsoleAppLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i > 3 && i < 7)
            //    {

            //        continue
            //        ;
            //    }
            //    Console.WriteLine(i);
            //}


            //Switch statements 
            Console.WriteLine("Enter the number of the day in the week (0-6): ");

            int dayNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Today is: " + GetDay(dayNumber));

            Console.ReadLine();

        }

        // ===========================================================
        // Switch statement

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }



    }
}
