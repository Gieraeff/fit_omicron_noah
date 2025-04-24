using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VehicelRentalApplication
{
    class Car : Vehicle
    {
        private int _seatCount;

        public Car(string description, string brand, int enginePower, int maxSpeed, int seatCount)
            : base(description, brand, maxSpeed, enginePower)
        {
            _seatCount = seatCount;
        }

        public int SeatCount
        {
            get { return _seatCount; }
        }

        public override string GetInfoString()
        {

            string info = $"{Description} - {Brand} - {EnginePower}PS";
            info += $"\n[{CurrentSpeed} / {MaxSpeed} km/h]";
            info += $"\nCount of seats: {_seatCount}";

            return info;
        }

        public override string ToString()
        {
            return GetInfoString();
        }
    }
}
