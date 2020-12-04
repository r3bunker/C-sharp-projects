using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _252_OverloadOperator
{
    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
            {
                return true;
                
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            return employee.ID != employee1.ID;
        }
        
    }
}

