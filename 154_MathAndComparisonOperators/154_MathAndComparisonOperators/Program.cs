using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _154_MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            int otherTotal = 22 + 32;
            int combinedTotal = total + otherTotal;
            Console.WriteLine("Five plus ten = " + total.ToString());
            Console.WriteLine("Total + otherTotal = " + combinedTotal);
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine(difference);

            int product = 10 * 5;
            Console.WriteLine(product);

            int quotient = 10 / 5;
            Console.WriteLine(quotient);

            int remainder = 101 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse.ToString());

            int roomTemp = 70;
            int currentTemp = 72;

            bool isWarm = currentTemp > roomTemp;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
