using System;

namespace ConsoleAppLesson12_StaticMethodAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            UsefulTools tools = new UsefulTools(); // cannot create a new instance of static class
            UsefulTools.SayHi("Duy");
            Console.ReadLine();
        }
    }
}
