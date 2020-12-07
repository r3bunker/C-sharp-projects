using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _314_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            { 
                // Ask user for age
                Console.WriteLine("How old are you?");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge < 1)
                {
                    throw new ApplicationException();
 
                }
    
                // Find year of birth
                DateTime year = DateTime.Now;
                int currentYear = year.Year;
                int userYearOfBirth = currentYear - userAge;

                // Display the year of birth
                Console.WriteLine("You were born in the year {0}.", userYearOfBirth);
                Console.ReadLine();
            }
            catch (ApplicationException)
            {
                Console.WriteLine("Please enter your current age. No negative numbers.");
                Console.ReadLine();
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter in digits, no letters.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Check your input.");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
