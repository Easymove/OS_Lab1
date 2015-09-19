using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Lab1
{
    class ProcessGenerator
    {
        private int cur_id = 1;
        private Random random = new Random();

        public Process gen_process(int min_time, int max_time)
        {
            cur_id++;
            return new Process(cur_id - 1, Time.parse_sec(random.Next(min_time, max_time)));
        }
    }
}
