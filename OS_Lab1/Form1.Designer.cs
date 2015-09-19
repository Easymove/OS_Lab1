namespace OS_Lab1
{
    partial class processApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.minComp = new System.Windows.Forms.TextBox();
            this.maxProcesses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxComp = new System.Windows.Forms.TextBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.logBox = new System.Windows.Forms.TextBox();
            this.doneBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Micra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(12, 396);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(531, 39);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // minComp
            // 
            this.minComp.Font = new System.Drawing.Font("Micra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minComp.Location = new System.Drawing.Point(12, 347);
            this.minComp.Name = "minComp";
            this.minComp.Size = new System.Drawing.Size(100, 27);
            this.minComp.TabIndex = 3;
            this.minComp.Text = "5";
            this.minComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxProcesses
            // 
            this.maxProcesses.Font = new System.Drawing.Font("Micra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxProcesses.Location = new System.Drawing.Point(12, 314);
            this.maxProcesses.Name = "maxProcesses";
            this.maxProcesses.Size = new System.Drawing.Size(100, 27);
            this.maxProcesses.TabIndex = 4;
            this.maxProcesses.Text = "10";
            this.maxProcesses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "max processes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(118, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(250, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "complexity";
            // 
            // maxComp
            // 
            this.maxComp.Font = new System.Drawing.Font("Micra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxComp.Location = new System.Drawing.Point(144, 347);
            this.maxComp.Name = "maxComp";
            this.maxComp.Size = new System.Drawing.Size(100, 27);
            this.maxComp.TabIndex = 7;
            this.maxComp.Text = "10";
            this.maxComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(545, 353);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(82, 21);
            this.timerLabel.TabIndex = 10;
            this.timerLabel.Text = "time:";
            // 
            // timerBox
            // 
            this.timerBox.Font = new System.Drawing.Font("Micra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBox.Location = new System.Drawing.Point(633, 351);
            this.timerBox.Name = "timerBox";
            this.timerBox.ReadOnly = true;
            this.timerBox.Size = new System.Drawing.Size(261, 27);
            this.timerBox.TabIndex = 9;
            this.timerBox.Text = "0";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Micra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(549, 396);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(531, 39);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(549, 0);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(531, 299);
            this.logBox.TabIndex = 12;
            // 
            // doneBox
            // 
            this.doneBox.Location = new System.Drawing.Point(12, 0);
            this.doneBox.Multiline = true;
            this.doneBox.Name = "doneBox";
            this.doneBox.Size = new System.Drawing.Size(531, 299);
            this.doneBox.TabIndex = 13;
            // 
            // processApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.doneBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxProcesses);
            this.Controls.Add(this.minComp);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 500);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "processApp";
            this.ShowIcon = false;
            this.Text = "Oparation Systems Lab_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox minComp;
        private System.Windows.Forms.TextBox maxProcesses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxComp;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox doneBox;
    }
}

