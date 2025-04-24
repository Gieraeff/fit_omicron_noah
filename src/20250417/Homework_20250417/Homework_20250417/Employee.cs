using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_20250417
{
    public class Employee
    {
		private string _name;
		private DateTime _birthday = DateTime.MinValue;
		private int _salary;
        private GenderState _genderState;
		private int _bonusSalary;

		public Employee(string Name, GenderState Gender, DateTime Birthday) 
		{
			_bonusSalary = 0;

			_name = Name;
			_birthday = Birthday;
			_genderState = Gender;
		}

		public int BonusSalary
		{
			get { return _bonusSalary; }
			set { _bonusSalary = value; }
		}



		public int Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}


		public DateTime Birthday
		{
			get { return _birthday; }
		}


		public string Name
		{
			get { return _name; }
		}


		public void CalculateSalary()
		{
			_salary += _bonusSalary;
		}

		public string GetInfoString()
		{
			string info = $"Name:{_name} Geburtstag: {_birthday} Geschlecht: {_genderState}";
			info += $"\n Zahltag: {_salary}";

			return info;
		}
	}
}
