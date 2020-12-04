using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // PART 1 //

        // Initialize one-dimensional array
        string[] strArray = { "Golf", "Batman", "Cheeseburger" };

        // Ask user for input
        Console.WriteLine("Please enter some text to add to the end of the strings.");
        string input = Console.ReadLine();

        // loop through the strArray and add the user input at the end of each
        for (int i = 0; i < strArray.Length; i++)
        {
            // concatenates the two strings into a new array
            string[] updatedArray = { strArray[i] + " " + input };
            
            // prints the new array one line at a time
            for (int j = 0; j < updatedArray.Length; j++)
            {
                Console.WriteLine(updatedArray[j]);
            }
        }
        Console.ReadLine();

        // PART TWO //

        // Infinite loop
        int k = 0;
        while (k == 0)
        {
            Console.WriteLine(strArray[k]);
            break;
        }
        Console.ReadLine();


        // PART THREE //

        // intialize golfScores array
        int[] golfScores = { 82, 78, 70, 85, 71, 72, 83 };

        // loop through golfScores
        for (int g = 0; g < golfScores.Length; g++)
        {
            // determine if the golfscore is under par
            if (golfScores[g] < 72)
            {
                Console.WriteLine("Rounds under par: " + golfScores[g]);
            }
            
        }
        Console.ReadLine();

        // Determine if golf score is par or better
        for (int g = 0; g < golfScores.Length; g++)
        {
            // determine if the golfscore is under par
            if (golfScores[g] <= 72)
            {
                Console.WriteLine("Rounds par or better: " + golfScores[g]);
            }

        }
        Console.ReadLine();

        // PART FOUR //

        // String list
        List<string> searchList = new List<string>() { "Eagles", "Astros", "Jazz"};

        bool isGuessed = false;
        while (!isGuessed)
        {

            // Ask user for input
            Console.WriteLine("Search:");
            string inputSearch = Console.ReadLine();
            bool stringFound = false;
        
            // Get index
            int index = searchList.FindIndex(a => a.Contains(inputSearch));


            // Loop through searchList for inputSearch
            for (int s = 0; s < searchList.Count; s++)
            {
                if (searchList[s] == inputSearch)
                {
                    // Displays index of item
                    Console.WriteLine("Index: " + index);
                    stringFound = true;
                    isGuessed = true;
                }
            }
            // Tells user item not found
            if (!stringFound) { Console.WriteLine("Search result not in the list");
            }
        }
        Console.ReadLine();


        // PART FIVE //

        // String list
        List<string> identicalList = new List<string>() {"socks","shirt","socks","shorts","shirt","pants"};

        // Ask user for input
        Console.WriteLine("Search:");
        string inputSearch2 = Console.ReadLine();
        bool stringFound2 = false;


        // Loop through searchList for inputSearch
        for (int h = 0; h < identicalList.Count; h++)
        {
            if (identicalList[h] == inputSearch2)
            {
                // Get index
                // Produce an enumeration of Indexes of inputSearch2
                var inputSearch2Indexes = identicalList
                    // First, add the index to the value by using Select with an anonymous type
                    .Select((t, i) => new { Index = i, Text = t })
                    // Keep only the inputSearch2 items
                    .Where(p => p.Text == inputSearch2)
                    // Use only indexes
                    .Select(p => p.Index);

                foreach (var i in inputSearch2Indexes)
                {
                    Console.WriteLine(inputSearch2 + " is found at index {0}", h);
                    stringFound2 = true;
                    break;
                    
                }

            }
        }
        // Tells user item not found
        if (!stringFound2)
        {
            Console.WriteLine("Search result not in the list");
        }
        Console.ReadLine();


        // PART SIX //
        
        // Create list
        List<string> list1 = new List<string>() { "red", "blue", "green", "blue","green"};
        List<string> list2 = new List<string>();
        bool equal = list2.Contains(Convert.ToString(list1));

        foreach (var i in list1)
        {
            //list2.Add(i);
            if (list2.Contains(i))
            {
                Console.WriteLine(i + ": has already appeared in the list.");
            }
            else
            {
                list2.Add(i);
                Console.WriteLine(i + ": has not appeared in the list.");
            }

        }
        Console.WriteLine("List of Numbers with no duplicates: {0}", string.Join(", ", list2));
        Console.ReadLine();
        
        


    }
}

