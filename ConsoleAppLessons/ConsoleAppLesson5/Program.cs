using System;

namespace ConsoleAppLesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(5, 5));
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            // Loop explain
            /* i = 0 < 5 result = 1 * 5 = 5  i = 1
             * i = 1 < 5 result = 5 * 5 = 25 i = 2
             * i = 2 < 5 result = 25 * 5 = 125 i = 3
             * i = 3 < 5 result = 125 * 5 = 625 i = 4
             * i = 4 < 5 result = 625 * 5 = 3125 i = 5
             * i = 5 = 5 return
             */



            return result;
        }
    }
}
