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
            panel1 = new Panel();
            button1 = new Button();
            btnDecrease = new Button();
            btnIncrease = new Button();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(332, 167);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(153, 65);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "25:00";
            // 
            // PomodoroTimer
            // 
            PomodoroTimer.Interval = 1000;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(50, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 100);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            Controls.Add(button1);
            Controls.Add(panel1);
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
        private Panel panel1;
        private Button button1;
        private Button btnDecrease;
        private Button btnIncrease;
    }
}