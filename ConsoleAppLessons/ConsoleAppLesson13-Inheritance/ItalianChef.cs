using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson13_Inheritance
{
    class ItalianChef : Chef
    {
        public void MakePizza()
        {
            Console.WriteLine("Italian Chef makes pizza");
        }

        public override void MakeSpecialDish() // override means override method from super class
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}
