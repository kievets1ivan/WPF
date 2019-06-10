using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Time
    {
        public int Hours { get; }
        public int Min { get; }
        public int Sec { get; }


        public Time(int hours, int min, int sec)
        {
            Hours = hours;
            Min = min;
            Sec = sec;
        }
        public Time(int min, int sec)
        {
            Hours = 0;
            Min = min;
            Sec = sec;
        }

        public int GetTime() => Sec + Min * 60 + Hours * 3600;

        public override string ToString()
        {
            if (Hours == 0)
                return $"{Min} хв. {Sec} сек.";
            return $"{Hours} г. {Min} хв. {Sec} сек.";
        }

    }
}
