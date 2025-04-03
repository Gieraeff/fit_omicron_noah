using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Toolbox.Tools
{
    public abstract class ConsoleTools
    {
        public static int GetInt(string inputPrompt)
        {
            string userInput = string.Empty;
            int intValue = 0;
            bool userInputinValid = false;

            do
            {
                Console.ResetColor();
                Console.Write(inputPrompt);
                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Console.ReadLine();

                try
                {
                    intValue = int.Parse(userInput);
                    userInputinValid = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    userInputinValid = true;
                }
            } while (userInputinValid);

            Console.ResetColor();

            return intValue;
        }
    }
}
