using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace _215_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel & Casino";


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }


            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "ya")
            {
                // Create player
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\RyanB\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                    
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Security! Kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing");

            }
            Console.WriteLine("Feel free to look around the Casino. Bye for now.");
            Console.Read();


        }
       
    }
}













// PRACTICE STEPS ----------------------------------------------------------------------------------







// Lamda expressions
//List<int> numList = new List<int>() { 1, 2, 3, 43, 543, 343 };

//int sum = numList.Where(x => x > 20).Sum();
//Console.WriteLine(sum);

//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

//foreach (Card card in newList)
//{
//    Console.WriteLine(card.Face);
//}

//int count = deck.Cards.Count(x => x.Face == Face.Ace);
//Console.WriteLine(count);

// Struct vs Class
//Card card1 = new Card();
//Card card2 = card1;
//card1.Face = Face.Eight;
//card2.Face = Face.King;

//Console.WriteLine(card1.Face);

// Enum
//public enum DaysOfWeek
//{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}


// Overload Operator
//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Ryan";
//game += player;
//game -= player;


//// Polymorphism
//List<Game> games = new List<Game>();
//Game game = new TwentyOneGame();
//games.Add(game);

//// Lists
//TwentyOneGame game = new TwentyOneGame();
//game.Players = new List<string>() { "Ryan", "Joe", "Bill" };
//game.ListPlayers();
//Console.ReadLine();
//game.Play()