using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _244_AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }
        
        public IQuittable Name { get; set; }

        public void Quit()
        {
            Console.WriteLine("Quittable");
        }
        public override void sayName()
        {
            base.sayName();
        }
        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
        

    }
}
