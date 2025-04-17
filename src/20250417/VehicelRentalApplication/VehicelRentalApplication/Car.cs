using System;
using System.Collections.Generic;
using System.Linq;
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


    }
}
