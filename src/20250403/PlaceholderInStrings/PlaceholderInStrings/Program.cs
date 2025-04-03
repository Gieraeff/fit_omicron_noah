using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceholderInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int maxnumber = 10;

            Console.WriteLine("Here were" + number +" items found.");
            Console.WriteLine("{0} items of {1} found.", number, maxnumber);

            Console.WriteLine($"{number} items of {maxnumber} are found.");

            string name = $"Noah-{DateTime.Now.Date}";
            
        }
    }
}
