using System;


namespace _140_DailyReport
{
    class Program
    {
        static void Main()
        {
            // Greeting
            Console.WriteLine("The Tech Academy\n\n" +
                "Student Daily Report");
            Console.ReadLine();

            // Daily Report

            // Name
            Console.WriteLine("\nWhat is your name?");
            string yourName = Console.ReadLine();

            // Course
            Console.WriteLine("\nWhat course are you on?");
            string yourCourse = Console.ReadLine();

            // Page Number
            Console.WriteLine("\nWhat page number?");
            string yourPage = Console.ReadLine();
            ushort pageNum = Convert.ToUInt16(yourPage); 

            // Help
            Console.WriteLine("\nDo you need help with anything? Please answer 'true' or 'false.'");
            string yourHelp = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(yourHelp);

            // Positive Experiences
            Console.WriteLine("\nWere there any postiive experiences you'd like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();

            // Feedback
            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();

            // Hours Studied
            Console.WriteLine("\nHow many hours did you study today?");
            string yourHours = Console.ReadLine();
            byte hoursStudied = Convert.ToByte(yourHours);

            // Thanks for submitting
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
