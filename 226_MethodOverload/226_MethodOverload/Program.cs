using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226_MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Instantiate class
            var operationObject = new MethodOverload();
            var addResults = operationObject.Operation(6);
            var decResults = operationObject.Operation(10.5m);
            var stringResults = operationObject.Operation("2");


            Console.WriteLine(addResults);
            Console.WriteLine(decResults);
            Console.WriteLine(stringResults);
            Console.ReadLine();


            
        }
    }
}
