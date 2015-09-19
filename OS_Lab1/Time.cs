using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Lab1
{
    public class Time
    {
        private int min;
        private int sec;
        private int msec;

        public Time()
        {
            this.min = 0;
            this.sec = 0;
            this.msec = 0;
        }

        public Time(int min, int sec, int msec)
        {
            this.min = min;
            this.sec = sec;
            this.msec = msec;
        }

        public Time(Time t)
        {
            this.min = t.min;
            this.sec = t.sec;
            this.msec = t.msec;
        }

        public void reset()
        {
            min = 0;
            sec = 0;
            msec = 0;
        }

        public void inc_min()
        {
            min += 1;
            if (sec >= 60)
            {
                this.reset();
            }
        }

        public void inc_sec()
        {
            sec += 1;
            if (sec >= 60) {
                this.inc_min();
                sec = 0;
            }
        }

        public void inc_msec(int msecs)
        {
            msec += msecs;
            if (msec >= 1000)
            {
                this.inc_sec();
                msec = msec - 1000;
            }
        }

        public string ToString()
        {
            return min.ToString() + " : " + sec.ToString() + " : " + msec.ToString();
        }

        public int ToInt()
        {
            return min * 60 + sec;
        }

        public static Time operator -(Time t1, Time t2)
        {
            int msec = t1.msec - t2.msec;
            int sec = t1.sec - t2.sec;
            int min = t1.min  - t2.min;
            if (msec < 0)
            {
                msec += 1000;
                sec--;
            }
            if (sec < 0)
            {
                sec += 60;
                min--;
            }
            return new Time(min, sec, msec);
        }

        public static Boolean operator <(Time t1, Time t2)
        {
            return t1.ToInt() < t2.ToInt();
        }

        public static Boolean operator >(Time t1, Time t2)
        {
            return t1.ToInt() > t2.ToInt();
        }

        public static Boolean operator <=(Time t1, Time t2)
        {
            return t1.ToInt() <= t2.ToInt();
        }

        public static Boolean operator >=(Time t1, Time t2)
        {
            return t1.ToInt() >= t2.ToInt();
        }

        public static Time parse_sec(int sec)
        {
            return new Time((int)Math.Truncate((double)(sec / 60)), (int)Math.Round((double)(sec % 60)), 0);
        }
    }
}
