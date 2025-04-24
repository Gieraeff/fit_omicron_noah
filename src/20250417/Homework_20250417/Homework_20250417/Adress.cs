using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_20250417
{
    class Adress
    {
		private string _street;
		private int _number;
		private int _postalCode;
		private string _city;
		private string _country;

		public string Country
		{
			get { return _country; }
		}

		public string City
		{
			get { return _city; }
		}


		public int PostalCode
		{
			get { return _postalCode; }
		}


		public int Number
		{
			get { return _number; }
		}

		public string Street
		{
			get { return _street; }
		}

		public string GetInfoString()
		{
			string info = $"Street: {_street} Number: {_number} PostalCode: {_postalCode} City:{_city} Country: {_country}";
			return info;
		}

	}
}