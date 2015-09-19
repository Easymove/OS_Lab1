using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Lab1
{
    class Process
    {
        public int id;
        public int state;
        public Time complexity;
        public Time deleyed;
        public Time start;
        public Time time_worked;
        public Time last_run;
        public Time finish;

        public Process(int id, Time complexity)
        {
            this.id = id;
            this.complexity = complexity;
            this.state = 0;
            this.deleyed = new Time();
            this.start = new Time();
            this.time_worked = new Time();
            this.last_run = new Time();
            this.finish = new Time();
        }

        public void run(Time time)
        {
            start = time;
            last_run = start;
            state = 1;
        }

        public void pause()
        {
            state = 2;
        }


        public void running(int tick)
        {
            time_worked.inc_msec(tick);
        }

        public void resume(Time time)
        {
            state = 1;
        }

        public void solve(Time time)
        {
            finish = time;
            deleyed = (finish - start) - complexity;
            state = 3;
        }
    }
}
