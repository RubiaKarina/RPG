using RPG.src.Entities;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 30, "Knight", 300); 
            Wizard wizard = new Wizard("Jennica", 35, "White Wizard", 100); 
            Ninja ninja = new Ninja("Pietro", 32, "Ninja", 250); 
            

            
            System.Console.WriteLine(arus.ToString());
            System.Console.WriteLine(wizard.Attack(7));
            System.Console.WriteLine(ninja.ToString());
            


        }
    }
}