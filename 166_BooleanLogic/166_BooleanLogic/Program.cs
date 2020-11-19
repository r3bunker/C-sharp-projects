using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _166_BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // And operator
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            // Or operator
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);

            // Equaliy operator
            Console.WriteLine(true == false);
            Console.WriteLine(true == true);

            // Not operator
            Console.WriteLine(true != false);
            Console.WriteLine(true != true);

            // Xor operator
            Console.WriteLine(true ^ false);
            Console.WriteLine(true ^ true);

            Console.ReadLine();
        }
    }
}
