using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _255_GenericType
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate List type string
            Employee<string> employees = new Employee<string>
            {
                Things = new List<string>()
            };
            employees.Things.Add("Josh");
            employees.Things.Add("Jake");
            employees.Things.Add("Ashley");
            employees.Things.Add("Bill");

            
            // Instantiate List type int
            Employee<int> employeeID = new Employee<int>
            {
                Things = new List<int>()
            };
            employeeID.Things.Add(3452);
            employeeID.Things.Add(5643);
            employeeID.Things.Add(5948);
            employeeID.Things.Add(8348);



            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }




            Console.ReadLine();

            
            

        }
    }
}
