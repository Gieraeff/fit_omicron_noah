using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicelRentalApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Noah";

            var mustang = new Car("Mustang shelby gt500 ","Ford",350,250);

            Console.WriteLine(mustang.GetInfoString());

            mustang.SpeedUp(120);

            Console.WriteLine(mustang.GetInfoString());

            mustang.SpeedUp(300);
        }
    }
}
