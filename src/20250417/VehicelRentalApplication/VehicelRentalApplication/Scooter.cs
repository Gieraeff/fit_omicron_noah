using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicelRentalApplication
{
    public class Scooter : Vehicle
    {
		private double _weight;
		private int _stateOfCharge;

		public void chargscooter(int charge)
		{
			if (_stateOfCharge+ charge < 100)
			{
				_stateOfCharge += charge;
				return;
			}
			_stateOfCharge = 100;
			return;
		}

		public Scooter(string description, string brand, int enginepower, int maxspeed,double weight)
			: base(description,brand,maxspeed,enginepower)
		{
			_weight = weight;
			_stateOfCharge = 50;
		}

        public Scooter(string description, string brand, int enginepower, double weight)
			: this(description, brand, 25, enginepower,weight){ }

        public double Weight
		{
			get { return _weight; }
		}

        public int StateOfCharge
        {
            get { return _stateOfCharge; }
        }

    }
}
