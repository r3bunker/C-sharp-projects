using System;


namespace _158_MathConsoleApp
{
    class Program
    {
        static void Main()
        {
            // Ask user for number to multiply by 50
            Console.WriteLine("Enter a number to multiply: ");
            int times50 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(times50 * 50);
            Console.ReadLine();

            // Ask user for number to add by 50
            Console.WriteLine("Enter a number to add: ");
            int add25 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(add25 + 50);
            Console.ReadLine();

            // Ask user for number to divide by 12.5
            Console.WriteLine("Enter a number to divide: ");
            int divide12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(divide12 / 12.5);
            Console.ReadLine();

            // Ask user for number to see if it's greater than 50
            Console.WriteLine("Enter a number to see if it's greater than 50: ");
            int greater50 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(greater50 > 50);
            Console.ReadLine();

            // Ask user for number to divide by 7 for remainder
            Console.WriteLine("Enter a number to find the remainder: ");
            int remainder7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(remainder7 % 7);
            Console.ReadLine();



        }
    }
}
