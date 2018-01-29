using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Boss : Employee
    {

        public string Car { get; set; }
        public int Bonus{ get; set; }


        public Boss()
        {

        }


        public Boss(string firstName, string lastName,int salary, string profession, string car, int bonus)
            : base(firstName, lastName, salary)
        {
            Car = car;
            Bonus = bonus;
        }



        public override string ToString()
        {
            return "Boss :\n" + "Name: "+ FirstName + "" + LastName + "" +"Salary: "+Salary + "" + " Profession:" + Profession + "" + "Car: "+  Car + "" +"Bonus:"+ Bonus;
        }

    }
}
