using System;


namespace VariableAndDataTypes_136
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNum = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNum);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number + 5 is: " + total);
            //Console.ReadLine();


            // Data Types //
            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char randomLetter = 'x';
            char questionMark = '\u2103';
            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 211.231241;
            float secondsLeft = 2.654f;
            short temperaturesOnMars = -341;
            string myName = "Ryan";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);



            Console.WriteLine(questionMark);
            Console.ReadLine();
        }
    }
}
