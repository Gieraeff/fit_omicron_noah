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
            var myradio = new Radio("BomBox");

            
            myradio.ChangeState(Powerstate.Poweron);
            myradio.Play();


            var mustang = new Car("Mustang shelby gt500", "Ford", 350, 250,5);
            var myScooter = new Scooter("hoverfly 2","Turbo",10,75);


            var vehicleList = new Vehicle[]
            {
                mustang,
                new Vehicle("Demo Vehicle","Brand New",111,99),
                new Vehicle("Audi urguattro","Audi",220,101),
                new Car("Octavia 4x4","Skoda",150,320,5),
                new Scooter("gt3 pro","Segway",10,75),
                myScooter,
            };

            //mustang.SpeedUp(120);

            //mustang.SpeedUp(300);

            foreach (var vehicle in vehicleList)
            {
                vehicle.SpeedUp(20);
                Console.WriteLine(vehicle.GetInfoString());
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
