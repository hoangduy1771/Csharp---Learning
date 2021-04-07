using System;

namespace ConsoleAppLesson13_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            //chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            //italianChef.MakeChicken();
            //italianChef.MakePizza();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }

    }
}
