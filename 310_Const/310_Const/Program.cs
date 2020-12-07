using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _310_Const
{
    class Program
    {
        static void Main(string[] args)
        {
            Character constructorCharacter = new Character("Test");
            // Const variable
            const string stadiumName = "Crucible";

            // Var variable
            var list = new List<string>() { "Titan", "Warlock", "Hunter" };

            Console.WriteLine("Welcome to the {0}!", stadiumName);
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, {0}. What is your starting class?", playerName);
            string startingClass = Console.ReadLine();

            Character userCharacter = new Character(playerName, startingClass);

            Console.WriteLine(constructorCharacter.Name + ":" + constructorCharacter.startingClass  + " vs " + userCharacter.Name + ":" + userCharacter.startingClass);


            Console.ReadLine();
            
        }
        public class Character
        {
            // Create properties of class Character
            public string Name { get; set; }
            public string startingClass { get; set; }

            public Character (string name, string subClass)
            {
                Name = name;
                startingClass = subClass;
            }
            public Character(string name) : this(name, "Hunter")
            {

            }

        }
    }
}
