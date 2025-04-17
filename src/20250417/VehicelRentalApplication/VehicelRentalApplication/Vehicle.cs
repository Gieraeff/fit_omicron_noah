using System;

namespace VehicelRentalApplication
{
    public class Vehicle
    {
        private string _description;
        private int _currentSpeed;
        private int _maxSpeed;
        private string _brand;
        private int _enginePower;


        public Vehicle(string description, string brand, int maxSpeed, int enginePower)
        {
            _currentSpeed = 0;

            _description = description;
            _maxSpeed = maxSpeed;
            _enginePower = enginePower;
            _brand = brand;
        }

        public int EnginePower
        {
            get { return _enginePower; }
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
        }

        public int CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }
        }

        public string Brand
        {
            get { return _brand; }
        }

        public string Description
        {
            get { return _description; }
        }


        //user spezific constructor
        //public Car(string description, int maxSpeed)
        //{
        //    _currentSpeed = 0;
        //    _description = description;
        //    _maxSpeed = maxSpeed;            
        //}

        public bool SpeedUp(int delta)
        {
            if (_currentSpeed + delta <= _maxSpeed)
            {
                _currentSpeed += delta;
                return true;
            }

            return false;
        }

        public string GetInfoString()
        {
            string info = $"{_description} - {_brand} - {_enginePower}PS";
            info += $"\n[{_currentSpeed} / {_maxSpeed} km/h]";

            return info;
        }
    }
}