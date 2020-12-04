using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _261_EnumChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for the day of the week
            Console.WriteLine("What day of the week is it?");
            try
            {
            Days.DaysOfWeek currentDay = (Days.DaysOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());

            Console.WriteLine(currentDay);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();

        }
        
    }
}
