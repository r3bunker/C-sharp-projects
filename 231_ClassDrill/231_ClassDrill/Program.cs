using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231_ClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate class
            var outputObject = new Output();

            // Ask user for number
            Console.WriteLine("Enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Call the method
            outputObject.outputInt(userNum);
            outputObject.outputInt(out int x);


            Console.WriteLine("Overload Output: {0}", x);

            int result = OtherClass.Sum(num1: 5,num2: 10);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
