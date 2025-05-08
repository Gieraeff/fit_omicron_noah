using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> doSomething;

            doSomething = WriteColoredMessage;

            doSomething("Calling a existing mehtod...");

            if (doSomething != null)
            {
                doSomething("Calling a existing mehtod...");
            }
            //is the same loke do Something with the question mark
            doSomething?.Invoke("Calling a existing mehtod...");
        }

        private static void WriteColoredMessage(string message)
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(message);

            Console.ForegroundColor = oldColor;
        }
    }
}
