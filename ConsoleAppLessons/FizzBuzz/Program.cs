﻿using System;

namespace FizzBuzz
{
    class Program
    {
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 15; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void Main(string[] args)
        {
            FizzBuzz();
            Console.ReadLine();
        }
    }
}
