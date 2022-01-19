using System;
using JogoGFT.src.Entities;

namespace JogoGFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus  = new Knight("Arus", 23, "Knight");            
            Wizard wizard = new Wizard ("Jenica", 30, "Wizard");
            Ninja ninja = new Ninja("Academico", 34, "Ninja");
            DarkWizard darkwizard = new DarkWizard("Geraldao", 50, "Dark Wizard");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(arus.Attack());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(darkwizard.Attack(8));
        }
    }
}
