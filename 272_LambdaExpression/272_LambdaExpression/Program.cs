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

            List<Employee> joeList = new List<Employee>();
            foreach (var employee in Employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Employee employeeJoe = new Employee();
                    joeList.Add(employee);
                }
            }
            

            // Lambda Expression for list of Joes
            List<Employee> lambdaJoeList = new List<Employee>();
            lambdaJoeList = Employees.FindAll(e => e.FirstName == "Joe").ToList();
            
            
            // Lambda expression for list of ID > 5
            List<Employee> lambdaIDList = new List<Employee>();
            lambdaIDList = Employees.FindAll(i => i.ID > 5).ToList();
           

            Console.ReadLine();
        }
    }
}
