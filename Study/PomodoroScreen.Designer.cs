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
            pnlTimer = new Panel();
            btnStartStop = new Button();
            btnDecrease = new Button();
            btnIncrease = new Button();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(320, 167);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(153, 65);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "25:00";
            // 
            // PomodoroTimer
            // 
            PomodoroTimer.Interval = 1000;
            PomodoroTimer.Tick += PomodoroTimer_Tick;
            // 
            // pnlTimer
            // 
            pnlTimer.BackColor = SystemColors.ControlDark;
            pnlTimer.Location = new Point(50, 280);
            pnlTimer.Name = "pnlTimer";
            pnlTimer.Size = new Size(689, 100);
            pnlTimer.TabIndex = 1;
            // 
            // btnStartStop
            // 
            btnStartStop.Location = new Point(357, 235);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(75, 23);
            btnStartStop.TabIndex = 2;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            btnDecrease.Location = new Point(479, 186);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(51, 58);
            btnDecrease.TabIndex = 3;
            btnDecrease.Text = "-";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            btnIncrease.Location = new Point(251, 186);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(56, 58);
            btnIncrease.TabIndex = 4;
            btnIncrease.Text = "+";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // PomodoroScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIncrease);
            Controls.Add(btnDecrease);
            Controls.Add(btnStartStop);
            Controls.Add(pnlTimer);
            Controls.Add(lblTimer);
            Name = "PomodoroScreen";
            Text = "PomodoroScreen";
            Load += PomodoroScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private System.Windows.Forms.Timer PomodoroTimer;
        private Panel pnlTimer;
        private Button btnStartStop;
        private Button btnDecrease;
        private Button btnIncrease;
    }
}