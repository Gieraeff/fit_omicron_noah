using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementToolApp_V1
{
    class Program
    {
        /*
         * Write an application with which student data can be managed. Following features should be implemented:

- Console application
- Clear user guidance through formatting and color coding (e.g.: color inputs)
- Student data should be able to be entered
- Participant data should be displayed on the screen
- All entries should be implemented in an exception free manner

a) Initial implementation for one participant only
        -Name
        -Birthday
        -Adress ( postal code, city)
         */
        static void Main(string[] args)
        {
            
            string userinput = string.Empty;           
            int postalCode = 0;
            string city = string.Empty;
            string name = string.Empty;
            DateTime birthday = DateTime.MinValue;
            bool userInputIsInvalid = false;

            Console.Clear();
            // Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;
            

            Console.WriteLine("please enter following information");
            Console.WriteLine();
            Console.Write("\tplease enter your full Name:               ");
            Console.ForegroundColor= ConsoleColor.Green;
            name = Console.ReadLine();

            do
            {
                Console.ResetColor();
                Console.Write("\tplease enter your birthday as dd.mm.yyyy:  ");
                Console.ForegroundColor = ConsoleColor.Green;
                userinput = Console.ReadLine();


                try
                {
                    birthday = DateTime.Parse(userinput);
                    userInputIsInvalid = false;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: " + ex.Message);

                    userInputIsInvalid = true;
                } 
            } 
            while (userInputIsInvalid);


            do
            {
                Console.ResetColor();
                Console.Write("\tcan you please enter you postal code:      ");
                Console.ForegroundColor = ConsoleColor.Green;
                userinput = Console.ReadLine();

                try
                {
                    postalCode = int.Parse(userinput);
                    userInputIsInvalid = false;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: " + ex.Message);
                    userInputIsInvalid = true;
                } 
            }
            while (userInputIsInvalid);


            Console.ResetColor();
            Console.Write("\tcool, which city is this exactly?:         ");
            Console.ForegroundColor = ConsoleColor.Green;
            city = Console.ReadLine();
            Console.ResetColor();



            if (!userInputIsInvalid)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\tso this is your data:");
                Console.WriteLine();
                Console.WriteLine("\tyour full Name:\t\t" + name);
                Console.WriteLine("\tyour birthday:\t\t" + birthday.ToString("dd/MM/yyyy"));
                Console.WriteLine("\tyour adress:\t\t" + postalCode.ToString() + " " + city);
            }
            


        }
    }
}
