using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson8_ClassAndObject
{
    class Book
    {
        // Class is a specification for a new data type (phone, water bottle) - model a real world entity
        // Attribute that describe what a book is (Blueprint of a book datatype)
        public string title;
        public string author;
        public int pages;

        // Constructor: special method in C# class, get called whenever created an object 
        public Book(string aTitle,string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages; 
            //Console.WriteLine("Creating Book");
        }

        public Book()
        {
            // Constructor 2 - Allow you to create a book in Program.cs with no parameter
        }
    }
}
