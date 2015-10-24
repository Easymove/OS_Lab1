using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace OS_Lab1
{
    class ProcessManager
    {
        public List<Process> processes_quiue = new List<Process>();
        public BindingList<Process> done_processes = new BindingList<Process>();
        public Process cur_process = null;
        private ProcessGenerator proc_gen = new ProcessGenerator();

        public String run_next(Time time, int tick)
        {
            String log_text = "";

            if (cur_process != null){
                cur_process.running(tick);
                if (cur_process.complexity.ToMsec() == cur_process.time_worked.ToMsec())
                {
                    log_text = log_text + " Process " + cur_process.id + " done! Time worked: " + cur_process.time_worked.ToString() + ".\n";
                    cur_process.solve(time);
                    done_processes.Add(cur_process);
                    processes_quiue.Remove(cur_process);
                    cur_process = null;
                    return log_text;
                }
            }

            if (cur_process == null){
                if (processes_quiue.Count > 0){
                    cur_process = processes_quiue[0];
                }
            }

            if (processes_quiue.Count > 0)
            {
                Process next_proc = processes_quiue.OrderBy((x) => (x.complexity.ToMsec() - x.time_worked.ToMsec())).First();
                
                if (cur_process.id != next_proc.id)
                {
                    log_text = log_text + " Process " + cur_process.id + " paused.\n";
                    cur_process.pause();
                    cur_process = next_proc;
                    if (next_proc.state == 0)
                    {
                        next_proc.run(time);
                        next_proc.running(tick);
                        log_text = log_text + " NEXT: new task " + next_proc.id + " remain work: " + (cur_process.complexity - cur_process.time_worked).ToString() + ".\n";
                    }
                    else
                    {
                        if (next_proc.state == 2)
                        {
                            next_proc.resume(time);
                            log_text = log_text + " NEXT: paused task " + next_proc.id + " remain work: " + (cur_process.complexity - cur_process.time_worked).ToString() + ".\n";
                        }
                        else
                        {
                            log_text = log_text + " Unexpected state detected.\n";
                        }
                    }
                }
            }
            return log_text;
        }

        public String gen_next(int min_time, int max_time, int tick, Time time, int max_processes, double chance)
        {
            String log_text = ""; 
            Random rand = new Random();
            if (chance * 100 > rand.Next(0, 100)){
                if (max_processes > (done_processes.Count + processes_quiue.Count))
                {
                    processes_quiue.Add(proc_gen.gen_process(min_time, max_time, tick, time));
                    log_text = log_text + " Process " + processes_quiue.Last().id + " added.\n";
                }
            }
            return log_text;
        }

        public Boolean all_done(int max_processes)
        {
            if (done_processes.Count >= max_processes)
            {
                return true;
            }
            return false;
        }
    }
}
