namespace Study
{
    partial class PomodoroScreen
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
            components = new System.ComponentModel.Container();
            lblTimer = new Label();
            PomodoroTimer = new System.Windows.Forms.Timer(components);
            lblFinished = new Label();
            btnStartStop = new Button();
            btnDecrease = new Button();
            btnIncrease = new Button();
            panel1 = new Panel();
            pnlComplete = new Panel();
            label1 = new Label();
            pnlIncrease = new Panel();
            panel1.SuspendLayout();
            pnlComplete.SuspendLayout();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(139, 22);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(202, 86);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "25:00";
            // 
            // PomodoroTimer
            // 
            PomodoroTimer.Interval = 1000;
            PomodoroTimer.Tick += PomodoroTimer_Tick;
            // 
            // lblFinished
            // 
            lblFinished.AutoSize = true;
            lblFinished.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinished.ForeColor = Color.FromArgb(117, 230, 218);
            lblFinished.Location = new Point(32, 10);
            lblFinished.Name = "lblFinished";
            lblFinished.Size = new Size(729, 65);
            lblFinished.TabIndex = 0;
            lblFinished.Text = "Complete! Time for a wee break";
            // 
            // btnStartStop
            // 
            btnStartStop.BackColor = Color.FromArgb(24, 154, 180);
            btnStartStop.FlatStyle = FlatStyle.Flat;
            btnStartStop.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartStop.Location = new Point(166, 111);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(148, 64);
            btnStartStop.TabIndex = 2;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.BackColor = Color.FromArgb(24, 154, 180);
            btnDecrease.FlatStyle = FlatStyle.Flat;
            btnDecrease.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            btnDecrease.ForeColor = Color.FromArgb(117, 230, 218);
            btnDecrease.Location = new Point(67, 33);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(66, 72);
            btnDecrease.TabIndex = 3;
            btnDecrease.Text = "-";
            btnDecrease.UseVisualStyleBackColor = false;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.BackColor = Color.FromArgb(24, 154, 180);
            btnIncrease.FlatStyle = FlatStyle.Flat;
            btnIncrease.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            btnIncrease.ForeColor = Color.FromArgb(117, 230, 218);
            btnIncrease.Location = new Point(347, 33);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(66, 72);
            btnIncrease.TabIndex = 4;
            btnIncrease.Text = "+";
            btnIncrease.UseVisualStyleBackColor = false;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnIncrease);
            panel1.Controls.Add(lblTimer);
            panel1.Controls.Add(btnStartStop);
            panel1.Controls.Add(btnDecrease);
            panel1.Location = new Point(217, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 178);
            panel1.TabIndex = 1;
            // 
            // pnlComplete
            // 
            pnlComplete.BackColor = Color.FromArgb(24, 154, 180);
            pnlComplete.Controls.Add(lblFinished);
            pnlComplete.Location = new Point(75, 136);
            pnlComplete.Name = "pnlComplete";
            pnlComplete.Size = new Size(798, 100);
            pnlComplete.TabIndex = 1;
            pnlComplete.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 19);
            label1.Name = "label1";
            label1.Size = new Size(354, 86);
            label1.TabIndex = 2;
            label1.Text = "Pomodoro";
            // 
            // pnlIncrease
            // 
            pnlIncrease.BackColor = Color.FromArgb(24, 154, 180);
            pnlIncrease.Location = new Point(48, 504);
            pnlIncrease.Name = "pnlIncrease";
            pnlIncrease.Size = new Size(52, 43);
            pnlIncrease.TabIndex = 3;
            // 
            // PomodoroScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(212, 241, 244);
            ClientSize = new Size(989, 642);
            Controls.Add(pnlIncrease);
            Controls.Add(label1);
            Controls.Add(pnlComplete);
            Controls.Add(panel1);
            Name = "PomodoroScreen";
            Text = "PomodoroScreen";
            Load += PomodoroScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlComplete.ResumeLayout(false);
            pnlComplete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private System.Windows.Forms.Timer PomodoroTimer;
        private Button btnStartStop;
        private Button btnDecrease;
        private Button btnIncrease;
        private Label lblFinished;
        private Panel panel1;
        private Panel pnlComplete;
        private Label label1;
        private Panel pnlIncrease;
    }
}