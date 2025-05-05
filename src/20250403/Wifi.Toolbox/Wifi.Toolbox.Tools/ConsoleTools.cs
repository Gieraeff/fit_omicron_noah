using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Toolbox.Tools
{
    public delegate void OperationErrorPosition(Exception exception);

    public abstract class ConsoleTools
    {
        //public static void CreateHeader(string headerText, char textFillChar)
        //{
        //    IArtWriter writer = new ArtWriter();

        //    var settings = new ArtSetting
        //    {
        //        ConsoleSpeed = 50,
        //        IsBreakSpace = false,
        //        Text = textFillChar.ToString(),
        //        BgText = " "
        //    };

        //    writer.WriteConsole(headerText, settings);
        //}

        //public static void CreateHeader(string headerText)
        //{
        //    CreateHeader(headerText, '*');
        //}


        public static string GetString(string inputPrompt)
        {
            string userInput = string.Empty;

            Console.Write(inputPrompt);
            Console.ForegroundColor = ConsoleColor.Yellow;

            userInput = Console.ReadLine();
            Console.ResetColor();

            return userInput;
        }

        public static T GetInputValue<T>(string inputPrompt) where T : struct
        {
            return GetInputValue<T>(inputPrompt);
        }

        public static T GetInputValue<T>(string inputPrompt, ErrorMessageHandler exceptionDrawer) where T : struct
        {
            string userInput = string.Empty;
            T userValue = default(T);
            bool userInputinValid = false;

            Type inputType = typeof(T);

            do
            {
                Console.ResetColor();
                Console.Write(inputPrompt);

                var lastInputPosition = new CursorPositionDto 
                { 
                    LeftPos = Console.CursorLeft,
                    TopPos = Console.CursorTop 
                };


                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Console.ReadLine();

                try
                {
                    var parseMethodInfo = inputType.GetMethod("Parse", new[] { typeof(string) });
                    if (parseMethodInfo == null)
                    {
                       throw new NotImplementedException($" Type {inputType.Name} doesn't support Parse().");
                    }

                    userValue = (T)parseMethodInfo.Invoke(null, new object[] { userInput });

                    //userValue = int.Parse(userInput);
                    userInputinValid = false;
                }
                catch (Exception ex)
                {
                    if(exceptionDrawer != null)
                    {
                        exceptionDrawer(ex,lastInputPosition); 
                    }
                    userInputinValid = true;
                }
            } while (userInputinValid);

            Console.ResetColor();

            return userValue;
        }


        public static void ErrorMessageBottom(Exception ex,CursorPositionDto cursorPosition)
        {
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("Error:" + ex.Message);
            if (ex.InnerException != null)
            {
                Console.WriteLine("\tERROR: " + ex.InnerException);
            }
        }

        public static void ErrorMessageDefault(Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);

            if (ex.InnerException != null)
            {
                Console.WriteLine("\tERROR: " + ex.InnerException);
            }


        }

    }
}
