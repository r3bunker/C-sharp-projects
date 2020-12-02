using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226_MethodOverload
{
    class MethodOverload
    {
        public int Operation(int input)
        {
            int addResult = input + 10;
            return addResult;
        }

        public int Operation(decimal input)
        {
            decimal decResult = input / 2;
            return (int)decResult;
        }

        public int Operation(string input)
        {
            int stringResult = Convert.ToInt32(input) - 5;
            return stringResult;
        }
    }
}
