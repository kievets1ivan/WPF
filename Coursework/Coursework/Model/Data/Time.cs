using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class Time
    {
        private int _hours;
        private int _min;
        private int _sec;


        public Time(int hours, int min, int sec)
        {
            _hours = hours;
            _min = min;
            _sec = sec;
        }
        public Time(int min, int sec)
        {
            _hours = 0;
            _min = min;
            _sec = sec;
        }

        public int GetTime() => _sec + _min * 60 + _hours * 3600;

        public override string ToString()
        {
            if (_hours == 0)
                return $"{_min} хв. {_sec} сек.";
            return $"{_hours} г. {_min} хв. {_sec} сек.";
        }

    }
}
