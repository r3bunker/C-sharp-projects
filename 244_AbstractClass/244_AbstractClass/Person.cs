using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _244_AbstractClass
{
    public abstract class Person
    {
        public string FirstName { get; set; }  
        public string LastName { get; set; }

        public virtual void sayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine(FullName);
        }

    }
}
