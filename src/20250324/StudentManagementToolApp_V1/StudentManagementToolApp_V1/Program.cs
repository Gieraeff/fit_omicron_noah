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
            string name;
            DateTime birthday = new DateTime();
            string userinput;           
            int postalCode = 0;
            string city;
        


            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            

            Console.WriteLine("please enter your full Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + " please enter your birthday as dd.mm.yyyy");
            userinput = Console.ReadLine();

            try
            {
                birthday = DateTime.Parse(userinput);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error wrong data");
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("great, can you please enter you postal code:");
            userinput = Console.ReadLine();


            try
            {
                postalCode = int.Parse(userinput);
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error wrong data");
                Console.WriteLine(ex.Message);
                return;
            }


            Console.WriteLine("cool, which city is this exactly?");
            city = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("\tso this is your data:");
            Console.WriteLine();
            Console.WriteLine("\tyour full Name:\t\t" +  name);
            Console.WriteLine("\tyour birthday:\t\t" + birthday.ToString("dd/MM/yyyy"));
            Console.WriteLine("\tyour postalcode:\t" + postalCode);
            Console.WriteLine("\tand your city:\t\t" + city);


        }
    }
}
