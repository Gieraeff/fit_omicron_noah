using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.Toolbox.Tools;

namespace Wifi.Toolbox.Testapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = ConsoleTools.GetInt("please enter your age");

            Console.WriteLine($"this is your {age}");
        }
    }
}
