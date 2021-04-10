using System;

namespace ConsoleAppOOP1
{
    class Program
    {


        static void Main(string[] args)
        {

            Students student1 = new("1", "Duy", 11, 11, 11);
            Console.WriteLine("Your ID is: " + student1.StudentID);
            Console.WriteLine("Your name is: " + student1.Name);
            Console.WriteLine("Your Grade In Math is: " + student1.GradeMath);
            Console.WriteLine("Your Grade In Literature is: " + student1.GradeLiterature);
            Console.WriteLine("Your Grade In Physics is: " + student1.GradePhysics);

            //Students student2 = new("2", "Long", 6, 5, 11);
            //Console.WriteLine("Your ID is: " + student2.StudentID);
            //Console.WriteLine("Your name is: " + student2.Name);
            //Console.WriteLine("Your Grade In Math is: " + student2.GradeMath);
            //Console.WriteLine("Your Grade In Literature is: " + student2.GradeLiterature);
            //Console.WriteLine("Your Grade In Physics is: " + student2.GradePhysics);


            Console.ReadLine();
        }
    }


}
