﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _244_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            IQuittable employee2 = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.sayName();
            
            

            employee2.Quit();
            Console.ReadLine();
        }
    }
}
