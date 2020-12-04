using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _252_OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Name = "Ryan";
            employee.ID = 60231;

            Employee employee1 = new Employee();

            employee1.Name = "Jake";
            employee1.ID = 60232;

            Console.ReadLine();
        }
    }
}
