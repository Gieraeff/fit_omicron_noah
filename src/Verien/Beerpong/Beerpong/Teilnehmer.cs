using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beerpong
{
    public class Teilnehmer
    {
        string _name;
        int _win = 0;
        int _lose = 0;
        int _winOverTime = 0;
        int _loseOverTime = 0;
        int _becher = 0;

        public int Win
        {
            get 
            { 
                return _win; 
            }
        }
        public int Lose
        {
            get
            {
                return _lose;
            }
        }
        public int Becher
        {
            get
            {
                return _becher;
            }
        }
        public int LoseOverTime
        {
            get
            {
                return _loseOverTime;
                
            }
        }

        public int WinOverTime
        {
            get
            {
                return _winOverTime;
            }
        }

        public int Display_Point()
        {

        }
    }
}
