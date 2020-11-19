using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _172_IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if/else statement
            int currentTemp = 50;
            if (currentTemp > 45)
            {
                Console.WriteLine("It's warm enough to golf!");

            }
            else
            {
                Console.WriteLine("It's too cold...sorry.");
            }
            Console.ReadLine();

            // != practice
            string name = "Ryan";
            if (name != "Ryan")
            {
                Console.WriteLine("You've got the wrong name");
            }
            else
            {
                Console.WriteLine("Nice name!");
            }
            Console.ReadLine();

            // greater than
            int age = 28;
            int votingAge = 18;
            if (age > votingAge)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You're not olde enough");
            }
            Console.ReadLine();

            // less than or equal
            int par = 72;
            int myScore = 81;
            if (myScore <= par)
            {
                
                Console.WriteLine("Wow! You shot under par, congrats!");
            }
            else
            {
                Console.WriteLine("You shot over par, work on your shortgame.");
            }
            Console.ReadLine();

            // Ternary operator
            int maxWeight = 500;
            int weight = 501;
            string result = weight < maxWeight ? "This package can be shipped." : "This package is too heavy.";
            Console.WriteLine(result);
            Console.ReadLine();

            // temperature app
            int roomTemp = 70;

            Console.WriteLine("Hi, what is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("Hi, " + yourName + ", what is the temperature where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            string tempComparison = currentTemperature >= roomTemp ? "It is a nice warm day there!" : "It seems like winter is coming.";
            Console.WriteLine(tempComparison);
            Console.ReadLine();

        }
    }
}
