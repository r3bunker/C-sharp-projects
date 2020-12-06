using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _272_LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee(){ FirstName = "Ryan", LastName = "Bunker", ID = 1},
                new Employee(){ FirstName = "Joe", LastName = "Montana", ID = 3},
                new Employee(){ FirstName = "Joe", LastName = "Burrow", ID = 8},
                new Employee(){ FirstName = "Alex", LastName = "Smith", ID = 13},
                new Employee(){ FirstName = "Drake", LastName = "Bell", ID = 11},
                new Employee(){ FirstName = "Brian", LastName = "Westbrook", ID = 34},
                new Employee(){ FirstName = "Brian", LastName = "Dawkins", ID = 43},
                new Employee(){ FirstName = "Will", LastName = "Smith", ID = 10},
                new Employee(){ FirstName = "Archie", LastName = "Bunker", ID = 17},
                new Employee(){ FirstName = "Joe", LastName = "Swanson", ID = 4},

            };

            List<string> joeList = new List<string>();
            foreach (var employee in Employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Employee employeeJoe = new Employee();
                    joeList.Add(Convert.ToString(employee.FirstName+ " " + employee.LastName+ " "+ employee.ID));
                }
            }
            Console.WriteLine("Joe List: ");
            Console.WriteLine(string.Join("\n", joeList));
            Console.ReadLine();

            // Lambda Expression for list of Joes
            List<string> lambdaJoeList = new List<string>();
            foreach (Employee employee in Employees.FindAll(e => e.FirstName == "Joe").ToList())
            {
                lambdaJoeList.Add(Convert.ToString(employee.FirstName + " " + employee.LastName + " " + employee.ID));
            }
            Console.WriteLine("Lambda Joe List: ");
            Console.WriteLine(string.Join("\n", lambdaJoeList));
            Console.ReadLine();

            // Lambda expression for list of ID > 5
            List<string> lambdaIDList = new List<string>();
            foreach (Employee employee in Employees.FindAll(i => i.ID > 5).ToList())
            {
                lambdaIDList.Add(Convert.ToString(employee.FirstName + " " + employee.LastName + " " + employee.ID));
            }
            Console.WriteLine("ID > 5");
            Console.WriteLine(string.Join("\n", lambdaIDList));

            Console.ReadLine();
        }
    }
}
