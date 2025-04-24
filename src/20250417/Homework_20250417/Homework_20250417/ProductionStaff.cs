using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_20250417
{
    public class ProductionStaff : Employee
    {

        public ProductionStaff(string Name, GenderState Gender, DateTime Birthday)
            : base(Name, Gender, Birthday)
        {

        }
    }
}
