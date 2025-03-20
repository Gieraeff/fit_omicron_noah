using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCircularCalculation
{
    class Program
    {

        static void Main(string[] args)
        {
            // variable declaration & initialisation
            double diameter = 15.12;
            double circumference = 0.0; // umfang 

            // calculation
            circumference = diameter * Math.PI;

            // output
            Console.WriteLine("The Circumference of my circle is: " + circumference.ToString());



        }
    }
}
