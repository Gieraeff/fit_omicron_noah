using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Of_Classes
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ma = new Employee();
            Employee ma1 = new Employee();
            Employee ma2 = new Employee();

            //ma2 => instace variable

            ma.Name = "Itachi Uchiha";
            ma.Salary = 1.500m;
            ma.Department = "DTP";
            ma.Id = Guid.NewGuid();

            ma.Display();



            //class vs. object vs. instance
            // class = type specification the data type himself 
            // object and instance is the same usage we have 3 different instances or object
            //  
        }
    }
}
 