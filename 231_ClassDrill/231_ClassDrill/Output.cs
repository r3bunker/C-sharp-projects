using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231_ClassDrill
{
    class Output
    {
        public void outputInt(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine("Result: " + num1 + " / 2 = " + result);
            return;
        }
        public void outputInt(out int x)
        {
            x = 10;
            x *= x;
        }
        public static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
