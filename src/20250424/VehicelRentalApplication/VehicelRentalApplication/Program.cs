using BetterConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicelRentalApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var myradio = new Radio();

            
            //myradio.ChangeState(Powerstate.Poweron);
            //myradio.Play();


            var mustang = new Car("Mustang shelby gt500", "Ford", 350, 250,5);
            var myScooter = new Scooter("hoverfly 2","Turbo",10,75);


            var vehicleList = new Vehicle[]
            {
                mustang,
                new Car("Demo Vehicle","Brand New",111,99,5),
                new Car("Audi urguattro","Audi",220,101,2),
                new Car("Octavia 4x4","Skoda",150,320,5),
                new Scooter("gt3 pro","Segway",10,75),
                myScooter,
            };

            foreach (var car in vehicleList)
            {
                car.SpeedUp(20);
                Console.WriteLine(car.GetInfoString());
                Console.WriteLine();
            }


            myScooter.chargscooter(25);

            ShowCarsAsTable(vehicleList);

            Console.WriteLine(myScooter.StateOfCharge);
            
            
        }

        private static void ShowCarsAsTable(Vehicle[] carList)
        {
            var table = new Table();
            table.From(carList);

            Console.WriteLine(table.ToString());
        }
    }
}
