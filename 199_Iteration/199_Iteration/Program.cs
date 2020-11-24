using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        //// INT FOR LOOP
        //int[] testScores = { 98, 99, 85, 78, 82, 34, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] >= 85)
        //    {
        //        Console.WriteLine("Passing test scores: " + testScores[i]);
        //    }
        //}
        //        Console.ReadLine();


        //// STR FOR LOOP
        //string[] names = { "Ryan", "Adam", "Kasey", "Kolby" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    if (names[j] == "Ryan")
        //    {
        //        Console.WriteLine(names[j]);
        //        Console.ReadLine();
        //    }
        //}


        //// LIST FOR LOOP
        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(95);
        //testScores.Add(87);
        //testScores.Add(72);
        //testScores.Add(74);
        //testScores.Add(60);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine(score);
        //    }
        //}
        //Console.ReadLine();

        //// STR LIST FOR LOOP
        //List<string> names = new List<string>() { "Ryan", "Kasey", "Jacob" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}
        //Console.ReadLine();


        // ADD TO LISTS FROM ANOTHER LIST
        List<int> testScores = new List<int>() { 98, 99, 100, 85, 75, 68 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();

    }
}

