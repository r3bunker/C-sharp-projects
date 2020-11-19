using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _187_Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            // Random number
            Random r = new Random();
            int rClub = r.Next(1, 14);

            Console.WriteLine("Your random club is: ");
            // Switch
            switch (rClub)
            {
                case 1:
                    Console.WriteLine("Driver");
                    break;
                case 2:
                    Console.WriteLine("4 wood");
                    break;
                case 3:
                    Console.WriteLine("3 iron");
                    break;
                case 4:
                    Console.WriteLine("4 iron");
                    break;
                case 5:
                    Console.WriteLine("5 iron");
                    break;
                case 6:
                    Console.WriteLine("6 iron");
                    break;
                case 7:
                    Console.WriteLine("7 iron");
                    break;
                case 8:
                    Console.WriteLine("8 iron");
                    break;
                case 9:
                    Console.WriteLine("9 iron");
                    break;
                case 10:
                    Console.WriteLine("Pitching Wedge");
                    break;
                case 11:
                    Console.WriteLine("Attack Wedge");
                    break;
                case 12:
                    Console.WriteLine("Sand Wedge");
                    break;
                case 13:
                    Console.WriteLine("Lob Wedge");
                    break;
                case 14:
                    Console.WriteLine("Putter");
                    break;
            }
            Console.ReadLine();
        }
    }
}
