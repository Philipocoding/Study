namespace Study
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            button4 = new Button();
            btnToDO = new Button();
            button2 = new Button();
            btnPomodoro = new Button();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(212, 241, 244);
            pnlMenu.Controls.Add(button4);
            pnlMenu.Controls.Add(btnToDO);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Controls.Add(btnPomodoro);
            pnlMenu.Location = new Point(93, 125);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(738, 426);
            pnlMenu.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 154, 180);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            button4.Location = new Point(93, 204);
            button4.Name = "button4";
            button4.Size = new Size(288, 127);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnToDO
            // 
            btnToDO.BackColor = Color.FromArgb(24, 154, 180);
            btnToDO.FlatStyle = FlatStyle.Flat;
            btnToDO.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btnToDO.Location = new Point(387, 71);
            btnToDO.Name = "btnToDO";
            btnToDO.Size = new Size(291, 127);
            btnToDO.TabIndex = 2;
            btnToDO.Text = "To-Do ";
            btnToDO.UseVisualStyleBackColor = false;
            btnToDO.Click += btnToDO_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 154, 180);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            button2.Location = new Point(387, 204);
            button2.Name = "button2";
            button2.Size = new Size(291, 127);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnPomodoro
            // 
            btnPomodoro.BackColor = Color.FromArgb(24, 154, 180);
            btnPomodoro.FlatStyle = FlatStyle.Flat;
            btnPomodoro.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btnPomodoro.Location = new Point(93, 71);
            btnPomodoro.Name = "btnPomodoro";
            btnPomodoro.Size = new Size(288, 127);
            btnPomodoro.TabIndex = 0;
            btnPomodoro.Text = "Pomodoro";
            btnPomodoro.UseVisualStyleBackColor = false;
            btnPomodoro.Click += btnPomodoro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 28);
            label1.Name = "label1";
            label1.Size = new Size(253, 65);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(212, 241, 244);
            ClientSize = new Size(989, 642);
            Controls.Add(label1);
            Controls.Add(pnlMenu);
            Name = "frmHome";
            Text = "Home";
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Button button4;
        private Button btnToDO;
        private Button button2;
        private Button btnPomodoro;
        private Label label1;
    }
}
