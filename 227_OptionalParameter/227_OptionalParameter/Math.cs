using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _227_OptionalParameter
{
    public class Math
    {
        public int getAdd(int input1, int input2 = 5)
        {
            return input1 + input2;
        }
    }
}
