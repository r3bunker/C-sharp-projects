using System;


namespace _147_MathChallenge
{
    class Program
    {
        static void Main()
        {
            // Ask for first number
            Console.WriteLine("Pick any number: ");
            string firstAnswer = Console.ReadLine();
            int num1 = Convert.ToInt32(firstAnswer); //converts string to int


            // Ask for second number
            Console.WriteLine("Pick another number: ");
            string secondAnswer = Console.ReadLine();
            int num2 = Convert.ToInt32(secondAnswer); //converts string to int

            // Addition
            int addition = num1 + num2;
            Console.WriteLine(firstAnswer + " + " + secondAnswer + " = " + addition);

            // Subtraction
            int subtraction = num1 - num2;
            Console.WriteLine(firstAnswer + " - " + secondAnswer + " = " + subtraction);

            // Multiplication
            int multiply = num1 * num2;
            Console.WriteLine(firstAnswer + " * " + secondAnswer + " = " + multiply);

            // Division
            int divide = num1 / num2;
            Console.WriteLine(firstAnswer + " / " + secondAnswer + " = " + divide);

            Console.ReadLine();

            // String concatenation
            string firstName = "Ryan";
            string lastName = "Bunker";
            Console.WriteLine(firstName + lastName);
            Console.ReadLine();

        }
    }
}
