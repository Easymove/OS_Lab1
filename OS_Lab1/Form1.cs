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
            manager = new ProcessManager();
            processBindingSource.DataSource = manager.done_processes;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = processBindingSource;

            timerBox.Text = 0.ToString();
            logBox.Text = "";
            cur_time.reset();
            timer.Enabled = true;
            timer.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cur_time.inc_msec(timer.Interval);
            logBox.AppendText(manager.run_next(new Time(cur_time), timer.Interval));
            logBox.AppendText(manager.gen_next(Int32.Parse(minComp.Text), Int32.Parse(maxComp.Text), timer.Interval, cur_time, Int32.Parse(maxProcesses.Text), 0.1));
            if (manager.all_done(Int32.Parse(maxProcesses.Text))){
                timer.Stop();
            }
            timerBox.Text = cur_time.ToString();    
        }

        
    }
}
