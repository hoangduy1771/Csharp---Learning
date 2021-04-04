using System;

namespace ConsoleAppLesson8_ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object is an instance of a class
            Book book1 = new Book("Harry Potter", "JK Rowling", 500); // create a book1 object based on Book class blueprint
            Book book2 = new Book("Lord of the Ring", "Tolkein", 1000);

            book2.title = "The hobbit"; // update title of book2

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            
            Console.ReadKey();

        }
    }
}
