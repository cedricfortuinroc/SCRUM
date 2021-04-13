using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace SoundSharpLib.Course
{
    public struct Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public Time(int seconds)
        {
            _hours = seconds / 3600;
            int rest = seconds % 3600;
            _minutes = rest / 60;
            _seconds = rest % 60;
        }

        public Time(int minutes, int seconds):this(minutes * 60 + seconds){}

        // public Time(int hours, int minutes, int seconds)
        // {
        //
        // }

        public override string ToString()
        {
            return $"{_hours.ToString()}:{_minutes.ToString()}:{_seconds.ToString()}";
        }
    }
}