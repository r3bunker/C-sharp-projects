using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231_ClassDrill
{
    public class Output
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
        
    }
}
