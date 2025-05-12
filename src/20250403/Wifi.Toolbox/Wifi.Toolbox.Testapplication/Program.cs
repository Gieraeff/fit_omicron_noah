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
            int age = ConsoleTools.GetInputValue<int>("please enter your age: ",ErrorHandler);

            double weight = ConsoleTools.GetInputValue<double>("wia schwer bisch: ",ErrorHandler);

            Console.WriteLine($"this is your age:{age} and your weight:{weight}");



            
        }

        private static void ErrorHandler(Exception ex, CursorPositionDto cursorPosition)
        {
            // Age:     *_______
            // Birthday: _______

            Console.SetCursorPosition(0,Console.WindowHeight - 2);
            Console.WriteLine("Huch: " + ex.Message);
            Console.ReadLine();

            Console.SetCursorPosition(cursorPosition.LeftPos, cursorPosition.TopPos);
            Console.WriteLine(new string(' ',Console.WindowWidth - cursorPosition.LeftPos - 1));
            Console.SetCursorPosition(0, cursorPosition.TopPos);
        }
    }
}
