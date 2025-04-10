using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampel2
{
    internal class Vehicle
    {
        // private object with underline lowercase
        private string _description;
        private int _currentSpeed;
        private int _maxSpeed;
        private ConsoleColor _color;

        //constructor ==> to create a valid object => Semantic consistency 


        // standard constructor
        //public Vehicle() 
        //{

        //}

        // sepzific constructor

        public Vehicle(string description, int maxspeed, ConsoleColor color)
        {
            _color = color;
            _currentSpeed = 0;

            _description = description;
            _maxSpeed = maxspeed;
        }

        public Vehicle(string description, int maxspeed)
        {
            _color = ConsoleColor.Green;
            _currentSpeed = 0;

            _description = description;
            _maxSpeed = maxspeed;
        }

        public int CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (value!= ConsoleColor.Black)
                {
                    _color = value; 
                }
            }
        }

        //java style programming
        //public int Get_CurrentSpeed()
        //{
        //    return CurrentSpeed;
        //}

        public void SpeedUp(int delta)
        {
            if ((_currentSpeed + delta) <= _maxSpeed)
            {
                _currentSpeed += delta;
            }
            else
            {
                _currentSpeed = _maxSpeed;
            }
        }

        public void Display()
        {

            ConsoleColor oldColor = Console.ForegroundColor;

            Console.ForegroundColor = _color;

            Console.WriteLine($"{_description} - [{_currentSpeed} / {_maxSpeed} km/h]");


        }

    }
}
