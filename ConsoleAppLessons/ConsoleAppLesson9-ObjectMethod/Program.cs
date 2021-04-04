using System;

namespace ConsoleAppLesson9_ObjectMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student2 = new Student("Pam", "Art", 3.6);
            Student student1 = new Student("Jim", "Bussiness", 2.8);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());


            Console.ReadLine();
        }
    }
}
