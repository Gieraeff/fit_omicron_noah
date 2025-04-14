using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("herr der ringe", "Tolkin","X-3218583");

            b1.Display();

            b1.Borrow(TimeSpan.FromDays(5));

            b1.Display();
        }
    }
}
