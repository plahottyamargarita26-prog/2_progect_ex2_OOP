using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_2_лаба_2_завдання_
{
    internal class MyTime
    {
        private int hour;
        private int min;
        private int sec;
        public MyTime(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
        public int Hour
        {
            get {return hour; }
        }
        public int Min
        {
            get { return min; }
        }
        public int Sec
        {
            get { return sec; }
        }
        public override string ToString()
        {
            return $"{hour}:{min:D2}:{sec:D2}";
        }
        public int ToSecSinceMidnight()
        {
            return hour * 3600 + min * 60 + sec;
        }
        public static MyTime FromSecSinceMidnight(int t)
        {
            int secPerDay = 60 * 60 * 24;

            t = t % secPerDay;

            if (t < 0)
            {
                t += secPerDay;
            }

            int hour = t / 3600;
            int min = (t / 60) % 60;
            int sec = t % 60;

            return new MyTime(hour, min, sec);
        }
        public MyTime Normalize()
        {
            int totalSeconds = ToSecSinceMidnight();

            return FromSecSinceMidnight(totalSeconds);
        }
        public MyTime AddSeconds(int s)
        {
            int totalSeconds = ToSecSinceMidnight();

            totalSeconds += s;

            return FromSecSinceMidnight(totalSeconds);
        }
        public MyTime AddOneSecond()
        {
            return AddSeconds(1);
        }
        public MyTime AddOneMinute()
        {
            return AddSeconds(60);
        }
        public MyTime AddOneHour()
        {
            return AddSeconds(3600);
        }
        public int Difference(MyTime other)
        {
            return ToSecSinceMidnight() - other.ToSecSinceMidnight();
        }
        public string WhatLesson()
        {
            int time = Normalize().ToSecSinceMidnight();
            int p1Start = 8 * 3600;
            int p1End = 9 * 3600 + 20 * 60;
            int p2Start = 9 * 3600 + 40 * 60;
            int p2End = 11 * 3600;
            int p3Start = 11 * 3600 + 20 * 60;
            int p3End = 12 * 3600 + 40 * 60;
            int p4Start = 13 * 3600;
            int p4End = 14 * 3600 + 20 * 60;
            int p5Start = 14 * 3600 + 40 * 60;
            int p5End = 16 * 3600;
            int p6Start = 16 * 3600 + 10 * 60;
            int p6End = 17 * 3600 + 30 * 60;

            if (time < p1Start)
                return "пари ще не почалися";

            if (time >= p1Start && time <= p1End)
                return "1-а пара";

            if (time > p1End && time < p2Start)
                return "перерва між 1-ю та 2-ю парами";

            if (time >= p2Start && time <= p2End)
                return "2-а пара";

            if (time > p2End && time < p3Start)
                return "перерва між 2-ю та 3-ю парами";

            if (time >= p3Start && time <= p3End)
                return "3-я пара";

            if (time > p3End && time < p4Start)
                return "перерва між 3-ю та 4-ю парами";

            if (time >= p4Start && time <= p4End)
                return "4-а пара";

            if (time > p4End && time < p5Start)
                return "перерва між 4-ю та 5-ю парами";

            if (time >= p5Start && time <= p5End)
                return "5-а пара";

            if (time > p5End && time < p6Start)
                return "перерва між 5-ю та 6-ю парами";

            if (time >= p6Start && time <= p6End)
                return "6-а пара";
            return "пари вже скінчилися";
        }
    }
}
