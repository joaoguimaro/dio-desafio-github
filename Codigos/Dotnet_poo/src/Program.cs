using System;
using Dotnet_poo.src.Entities;

namespace Dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 50, 10);
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 30, 40);
            Ninja takeshi = new Ninja("Takeshi", 34, "Ninja", 60, 20);
            Black_Wizard vaati = new Black_Wizard("Vaati", 50, "Black Wizard", 70, 100);

            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard);
            Console.WriteLine(wizard.Attack(4));
            Console.WriteLine(takeshi);
            Console.WriteLine(takeshi.Attack(1));
            Console.WriteLine(vaati);
            Console.WriteLine(vaati.Attack(8));
        }
    }
}
