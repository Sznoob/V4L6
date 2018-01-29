using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
       
        public Employee()
        {

        }
        
        public Employee(string firstName, string lastName, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }


        public override string ToString()
        {
            return "Employee: \n" + FirstName + "" + LastName + "" + Salary + "" + Profession  ;
        }

    }
}
