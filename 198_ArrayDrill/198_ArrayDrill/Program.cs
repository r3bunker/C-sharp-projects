using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _198_ArrayDrill
{
    class Program
    {
        static void Main()
        {
            // Initialize string array
            string[] strArray = { "Football", "Baseball", "Basketball", "Soccer", "Hockey" };

            // Ask user for index
            Console.WriteLine("Select an index (0-4)");
            int selectedIndex = int.Parse(Console.ReadLine());

            // Check to make sure selectedIndex is within the strArray range
            if (selectedIndex >= 0 && selectedIndex <= 4 )
            {
                // Display selected index
                Console.WriteLine("Index string selected: " + strArray[selectedIndex]);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Sorry there is no value associated with that index. Please selected (0-4)");
                Console.ReadLine();
            }




            // Initialize int array
            int[] intArray = { 3, 36, 80, 82};

            // Ask user for index
            Console.WriteLine("Select an index (0-3)");
            int selectedInt = int.Parse(Console.ReadLine());

            // Check to make sure selectedInt is within intArray range
            if (selectedInt >= 0 && selectedInt <= 3)
            {
                Console.WriteLine("Index int selected: " + intArray[selectedInt]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry there is no value associated with that index. Please selected (0-3)");
                Console.ReadLine();
            }


            // Intialize List
            List<string> strList = new List<string>();
            strList.Add("Star Wars");
            strList.Add("Lord of the Rings");
            strList.Add("Marvel");
            strList.Add("Harry Potter");
            strList.Add("Indiana Jones");
            strList.Add("Jurassic Park");

            // Ask user for index input
            Console.WriteLine("Please select and index input for a movie selection (0-5)");
            int selectedMovie = int.Parse(Console.ReadLine());

            // Check to make sure selectedMovie is in strList range
            if (selectedMovie >= 0 && selectedMovie <= 5)
            {
                Console.WriteLine("You have selected: " + strList[selectedMovie] + "! Enjoy your movie!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry there is no value associated with that index. Please selected (0-5)");
                Console.ReadLine();
            }
        }
    }
}
