using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _227_OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate method 
            var addition = new Math();

            // Ask user for input1
            Console.WriteLine("Enter in a number");
            int input1 = Convert.ToInt32(Console.ReadLine());

            // Ask user for input2
            Console.WriteLine("Enter in another number (optional)");
            int input2;
            int result;
            if (int.TryParse(Console.ReadLine(), out input2))
            {
                result = addition.getAdd(input1, input2);
            }
            else
            {
                result = addition.getAdd(input1);
            }

            Console.WriteLine("Total sum: " + result);
            Console.ReadLine();
        }
    }
}
