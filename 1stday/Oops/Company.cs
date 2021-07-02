using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Company
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public Person Employee { get; set; }

        public Company()
        {
            Employee = new Person();
            Employee.Name = "John";
            Employee.Age = 35;
            Employee.Check = 20;
            Employee.PrintCheck();
        }

        
      
    }
    
}
