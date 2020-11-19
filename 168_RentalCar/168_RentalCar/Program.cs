using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _168_RentalCar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for age
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            // Ask for DUI
            Console.WriteLine("\nHave you ever had a DUI? (true or false)");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            // Speeding tickets
            Console.WriteLine("\nHow many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Qualifications
            Console.WriteLine("\nQualified?");
            bool isQualified = (yourAge > 15 && DUI == false && speedingTickets < 3);
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
