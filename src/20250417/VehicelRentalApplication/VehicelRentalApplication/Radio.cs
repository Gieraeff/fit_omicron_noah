using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicelRentalApplication
{
    class Radio
    {
		private string _stationName;
		private int _volume;
		private Powerstate _powerstate;

		public Radio(string statioName)
		{
			_stationName = statioName;
			_volume = 0;
			_powerstate = Powerstate.Poweroff;
		}

		public void ChangeVolume(int volume)
		{
			if (_volume + volume < 10)
			{
				_volume += volume;
				return;
			}

			_volume = 10;
			return;
		}

		public void ChangeState(Powerstate newState)
		{
			_powerstate = newState;
		}

		public void Play()
		{
			//_powerstate = Powerstate.Poweron;
			if (_powerstate == Powerstate.Poweron)
			{
				Console.WriteLine($"{_stationName}:\n *untz* *untz* *untz*");
				return;
			}

            Console.WriteLine("wrong powerstate");
			return;
		}

        public Powerstate State
        {
            get { return _powerstate; }
        }

        public int Volume
		{
			get { return _volume; }
		}

		public string StationName
		{
			get { return _stationName; }
		}

	}
}
