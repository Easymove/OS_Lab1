using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Lab1
{
    public partial class processApp : Form
    {
        private Time cur_time = new Time();
        private ProcessManager manager = new ProcessManager();

        public processApp()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            logBox.Text = "";
            manager = new ProcessManager();
            cur_time.reset();
            timerBox.Text = 0.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cur_time.inc_msec(timer.Interval);
            logBox.AppendText(manager.run_next(new Time(cur_time), timer.Interval));
            logBox.AppendText(manager.gen_next(Int32.Parse(minComp.Text), Int32.Parse(maxComp.Text), Int32.Parse(maxProcesses.Text), 0.1));
            if (manager.all_done(Int32.Parse(maxProcesses.Text))){
                timer.Stop();
                doneBox.AppendText("================================================\n");
                foreach (Process p in manager.done_processes)
                {
                    doneBox.AppendText("id:  " + p.id + "  ; start:  " + p.start.ToString() + "  ; complexity:  " + 
                        p.complexity.ToString() + "  ; finish:  " + p.finish.ToString() + "  ; delay:  " + p.deleyed.ToString() + "  ;\n");
                }
            }
            timerBox.Text = cur_time.ToString();    
        }

        
    }
}
