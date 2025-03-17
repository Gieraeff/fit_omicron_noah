using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Blue; //the text will get blue but we don t get a blue screen 
            Console.Clear();                              // we needed first to clear the

            Console.WriteLine("This is my First friendly blue screen!");
            Console.Write("testing something:");
            Console.Write("what up");

            Console.WriteLine("this is \n a new line");
            Console.WriteLine("Age: \t 55");
            Console.WriteLine("\"Hallo\"      \\t");
            

            /*
             * Write an application that producces the following outputs:
             *  
             *  Name:               <your name>
             *  Place of residence <your place of residence>
             *  
             *<Here should be your motto>.
             *  
             */

            Console.WriteLine();
            Console.WriteLine("\t Name: \t\t     Noah Zech");
            Console.WriteLine("\t Place of residence: Wald");
            Console.WriteLine();
            Console.WriteLine("just gona send it");

        }
    }
}
