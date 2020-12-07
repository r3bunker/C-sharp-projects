using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Current time
            Console.WriteLine("Current time: {0}", DateTime.Now);
            Console.ReadLine();

            // Ask user for number
            Console.WriteLine("Please enter a number of hours.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Exact time in X hours
            DateTime currentTime = DateTime.Now;
            DateTime futureTime = currentTime.AddHours(userNum);
            Console.WriteLine("\nThe time will be: {0} in {1} hours from now.", futureTime, userNum);
            Console.ReadLine();
        }
    }
}
