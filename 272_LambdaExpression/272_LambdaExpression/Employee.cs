using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _272_LambdaExpression
{
    public class Employee
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void fullContact()
        {
            string employee = FirstName + " " + LastName + " : " + ID;
            Console.WriteLine(employee);
        }
    }
}
