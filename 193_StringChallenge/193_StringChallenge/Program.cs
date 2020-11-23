using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _193_StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // String variables
            string greeting = "Hello, ";
            string fName = "Ryan";
            string lName = "Bunker";

            // Concatenate strings
            string message = greeting + fName + " " + lName;

            // Write to console
            Console.WriteLine(message);
            Console.ReadLine();

            // change message to ALL CAPS
            message = message.ToUpper();
            Console.WriteLine(message);
            Console.ReadLine();

            // stringbuilder 
            StringBuilder sb = new StringBuilder();
            sb.Append("This is an example of how to use stringbuilder.\n");
            sb.AppendLine("We can append lines on top of each other to form paragraphs.");
            sb.AppendLine("Here is an additional appended line.");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
