using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop
            int n = 0;
            while(n < 20)
            {
                Console.WriteLine("{0}", n);
                n++;
            }

            // Do while loop
            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);
                i++;

            }
            while(i<10);
            Console.ReadLine();
        }
    }
}
