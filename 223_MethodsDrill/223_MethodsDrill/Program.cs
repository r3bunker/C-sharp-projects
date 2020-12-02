using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _223_MethodsDrill
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            // Ask user for number 
            Console.WriteLine("Enter in a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Call methods
            var operationObject = new Operation();
            var result = operationObject.getMultiply(userNum, 5);
            result = operationObject.getDivide(result, 2);
            result = operationObject.getAdd(result, 10);

            // Print result 
            Console.WriteLine("Results: " + result);
            Console.ReadLine();

            
        }

        
    }
}
