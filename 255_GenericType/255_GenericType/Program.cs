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
            Employee<int> employeeIDs = new Employee<int>
            {
                Things = new List<int>()
            };
            employeeIDs.Things.Add(3452);
            employeeIDs.Things.Add(5643);
            employeeIDs.Things.Add(5948);
            employeeIDs.Things.Add(8348);


            // Iterate through employees 
            foreach (string employee in employees.Things)
            {
                Console.WriteLine(employee);
            }

            // Iterate through employeeIDs
            foreach (int employeeID in employeeIDs.Things)
            {
                Console.WriteLine(employeeID);
            }




            Console.ReadLine();

            
            

        }
    }
}
