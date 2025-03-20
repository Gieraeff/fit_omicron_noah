using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
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
            userInput = Console.ReadLine();
            //implicity ==> indirekt, unbeabsichtigt
            //explicit ==> klar definiert

            try // not very efficence if there is a lot in it - try as short as possible
            {
                //convert user input into a numeric value
                yearOfBirth = int.Parse(userInput);


            }
            catch (FormatException formatEx)
            {
                Console.WriteLine("\a du aff " + formatEx.Message);

                return;
            }
            catch (Exception)
            {

                Console.WriteLine("\a wtf"); // ex.Message sind vorgefertigte error antworten für die abgefangenen expception
                return;
            }
            finally // finally wird immer verwendet egal ob error oder nicht kann bei files verwendet werden die einen platz halten wenn es crashed
            {
                Console.WriteLine("ping!");
            }

            // calculate the age
            age = DateTime.Now.Year - yearOfBirth;

            //output all user info
            Console.WriteLine("Damn " + name + " you are " + age);

        }
    }
}
