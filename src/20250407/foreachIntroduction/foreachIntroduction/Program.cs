using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachIntroduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Gandalf", "Max Musterman", "Golum", "Emor" };

            foreach(string name in names)
            {
                Console.WriteLine($"Name: {name}");
            }
        }
    }
}
