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
