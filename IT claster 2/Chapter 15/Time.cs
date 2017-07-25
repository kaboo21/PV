using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15
{
    class Time
    {
        int hour;
        int minute;

        public Time(int h, int m)
        {
            if (h < 0 || m < 0)
                throw new InvalidTimeFormatException("Time can't be negative");
            else 
            {
                minute = m % 60;
                hour= ((int)m / 60 + h)%24;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} hour(s) {1} minute(s)", hour, minute);
        }


        public static Time ConvertFromIntToTime(int minute)
        {
            if (minute < 0)
                throw new InvalidTimeFormatException("Time can't be negative");
            else
                return new Time((int)(minute / 60), minute % 60);
        }

    }
}
