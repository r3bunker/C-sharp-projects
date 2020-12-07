using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _297_LogFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for number
            Console.WriteLine("Please enter any number");
            int userNum = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\RyanB\Logs\userNum.txt", true))
            {
                file.WriteLine(userNum);
            }

            string text = File.ReadAllText(@"C:\Users\RyanB\Logs\userNum.txt");

            Console.ReadLine();

        }
    }
}
