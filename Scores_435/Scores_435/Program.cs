using System;

namespace Scores_435
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome Back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\RyanB\Desktop\Tech_Academy\GitHub\C-sharp-projects\Scores_435\Scores_435\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            double tScore = 0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach(string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double aveScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + aveScore);


            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
