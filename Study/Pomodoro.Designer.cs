namespace Study
{
    partial class Pomodoro
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
            PomodoroTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            txtbTime = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // PomodoroTimer
            // 
            PomodoroTimer.Interval = 1000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 133);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // txtbTime
            // 
            txtbTime.Location = new Point(292, 178);
            txtbTime.Name = "txtbTime";
            txtbTime.Size = new Size(198, 23);
            txtbTime.TabIndex = 1;
            txtbTime.Text = "25:00";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(326, 236);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 40);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // Pomodoro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(txtbTime);
            Controls.Add(label1);
            Name = "Pomodoro";
            Text = "Pomodoro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer PomodoroTimer;
        private Label label1;
        private TextBox txtbTime;
        private Button btnStart;
    }
}