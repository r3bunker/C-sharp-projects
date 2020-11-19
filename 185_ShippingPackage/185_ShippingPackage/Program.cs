using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _185_ShippingPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below: ");
            Console.ReadLine();

            // Ask user for weight of package
            Console.WriteLine("\nWhat is the weight of your package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            
            if (packageWeight > 50)
            {
                // if package is too heavy display this message
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            // Ask user for the width of package
            Console.WriteLine("\nPlease enter the width of the package: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            // Ask user for height of package
            Console.WriteLine("\nPlease enter the height of the package: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            // Ask user for length of package
            Console.WriteLine("\nPlease enter the length of the package: ");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            // if dimensions are too big
            if (packageHeight * packageLength * packageWidth>= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }

            // Quote equation
            int quote = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
            Console.WriteLine("\nYour total comes to: " + "$" + quote );
            Console.ReadLine();




        }
    }
}
