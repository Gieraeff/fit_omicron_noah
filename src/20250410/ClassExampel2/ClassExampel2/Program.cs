using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string userinput = String.Empty;

            Vehicle car1 = new Vehicle("Pegasus",200);

            //car1.Description = "ford mustang green edition";
            //car1.MaxSpeed = 300;
            ////car1.CurrentSpeed = 0;
            //car1.Color =ConsoleColor.Green;

            car1.Display();


            //userinput = Console.ReadLine();
            car1.SpeedUp(100);

            car1.Display();

            
            car1.SpeedUp(120);


            car1.Color = ConsoleColor.DarkMagenta;
            Console.WriteLine(car1.Color);

            int speed = car1.CurrentSpeed * 150;
            car1.Display();

        }
    }
}

