using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodBasics
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //methods needs
            // - reduce code line
            // - reuse code
            // - increase readability
            // - easier debugging
            // - unit tests

            PrintHelloWorld();

            PrintMessage("what the fuck");

            PrintColoredMessage("what the fuck", ConsoleColor.Green);

            PrintMessage("what the fuck");
        }
        
        static void PrintColoredMessage(string message, ConsoleColor messageColor)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = messageColor;
            Console.WriteLine(message); 
            Console.ForegroundColor = oldColor;
        }
        
        static void PrintMessage(string message)
        { 
            Console.WriteLine(message); 
        }


        //signature
        // return type - name (parameter list)
        static void PrintHelloWorld()
        {
            Console.WriteLine("HelloWorld");
        }
    }
}
