using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Lab1
{
    class ProcessManager
    {
        public List<Process> processes_quiue = new List<Process>();
        public List<Process> done_processes = new List<Process>();
        public Process cur_process = null;
        private ProcessGenerator proc_gen = new ProcessGenerator();

        public String run_next(Time time, int tick)
        {
            String log_text = "";
            if (processes_quiue.Count > 0)
            {
                if (cur_process == null)
                {
                    cur_process = processes_quiue[0];
                    log_text = log_text + " Running task " + cur_process.id + " remain work: " + (cur_process.complexity - cur_process.time_worked).ToString() + ";\n";
                }

                cur_process.running(tick);
                if (cur_process.complexity <= cur_process.time_worked)
                {
                    cur_process.solve(time);
                    log_text = log_text + "Task " + cur_process.id + " done; time worked: " + cur_process.time_worked.ToString() + ".\n";
                    done_processes.Add(cur_process);
                    processes_quiue.Remove(cur_process);
                    if (cur_process == null && processes_quiue.Count > 0)
                    {
                        cur_process = processes_quiue[0];
                    }
                    else {
                        cur_process = null;
                        log_text = log_text + " Waiting for tasks.\n";
                    }
                }

                foreach (Process proc in this.processes_quiue)
                {
                    if ((cur_process != null) && ((proc.complexity - proc.time_worked) < (cur_process.complexity - cur_process.time_worked)))
                    {
                        cur_process.pause();
                        cur_process = proc;
                        if (proc.state == 0)
                        {
                            proc.run(time);
                            log_text = log_text + " Running new task " + proc.id + " remain work: " + (cur_process.complexity - cur_process.time_worked).ToString()  + ".\n";
                            break;
                        }
                        else
                        {
                            if (proc.state == 2)
                            {
                                proc.resume(time);
                                log_text = log_text + " Resuming paused task " + proc.id + " remain work: " + (cur_process.complexity - cur_process.time_worked).ToString() + ".\n";
                            }
                            else
                            {
                                log_text = log_text + " Unexpected state detected.\n";
                            }
                            break;
                        }
                    }
                }
            }
            return log_text;
        }

        public String gen_next(int min_time, int max_time, int max_processes, double chance)
        {
            String log_text = ""; 
            Random rand = new Random();
            if (chance * 100 > rand.Next(0, 100)){
                if (max_processes > (done_processes.Count + processes_quiue.Count))
                {
                    processes_quiue.Add(proc_gen.gen_process(min_time, max_time));
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
