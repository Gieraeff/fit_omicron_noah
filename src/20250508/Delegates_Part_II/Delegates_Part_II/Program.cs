using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Part_II
{

    public delegate void DoSomething(string message); // ==> Actions


    public delegate bool Check(string message); // ==> Functions
    // delegates wich return bool = Predicate


    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = WriteColorMessage;
            DoSomething customAction = WriteColorMessage;

            Func<string, bool> function = CheckParameter;
            Check customFunction = CheckParameter;

            Predicate<string> preCheck = CheckParameterValue;
        }

        private static bool CheckParameterValue(string parameter)
        {
            return true;
        }

        private static bool CheckParameter(string message)
        {


            return true;
        }

        private static void WriteColorMessage(string message)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(message);

            Console.ForegroundColor = oldColor;
        }
    }
}
