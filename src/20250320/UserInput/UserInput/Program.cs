using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string userInput = string.Empty;
            int yearOfBirth = 0;
            int age = 0;

            //get the name of the user
            Console.Write("please enter your name:");
            name = Console.ReadLine();

            // read year of birth
            Console.WriteLine("Hello, " + name);
            Console.WriteLine(" please enter the year of your Birth: ");
            
            //implicity ==> indirekt, unbeabsichtigt
            //explicit ==> klar definiert
            
           
           
                userInput = Console.ReadLine();
            

            

            //convert user input into a numeric value
            yearOfBirth = int.Parse(userInput);

            // calculate the age
             age = DateTime.Now.Year - yearOfBirth;
            
            //output all user info
            Console.WriteLine("Damn " + name + " you are "+ age);
        }
    }
}
