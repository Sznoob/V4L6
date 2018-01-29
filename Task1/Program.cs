using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Worker = new Employee();
            Worker.FirstName = " Kirsi ";
            Worker.LastName = " Kernel ";
            Worker.Profession = " Teacher ";
            Worker.Salary = 1800;
            Console.WriteLine(Worker.ToString());

            Boss BigBoss = new Boss();
            BigBoss.FirstName = " Jussi ";
            BigBoss.LastName = " Jurkka ";
            BigBoss.Profession = "Head of Institute Salary";
            BigBoss.Salary = 9000;
            BigBoss.Car = " Mersu ";
            BigBoss.Bonus = 5000;
            //BigBoss.Profession "ICT-engineer";
            Console.WriteLine(BigBoss.ToString());


        }
    }
}
