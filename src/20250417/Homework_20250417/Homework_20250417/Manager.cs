using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_20250417
{
    public class Manager : Employee
    {

        public  Manager(string Name, GenderState Gender, DateTime Birthday)
                : base(Name, Gender, Birthday)
        {

        }
    }
}
