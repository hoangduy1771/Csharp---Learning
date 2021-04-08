using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 10;
            Console.WriteLine(a);
            int b = Convert.ToInt32("1234567");


            Console.WriteLine(IsInteger(b));

        }

        public static bool IsInteger(double d)
        {
            if (d == (int)d) return true;
            else return false;
        }
    }
}
