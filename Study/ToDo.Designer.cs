namespace Study
{
    partial class ToDo
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
            txtbEnterData = new TextBox();
            checkBox1 = new CheckBox();
            checkList = new CheckedListBox();
            btnAdd = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtbEnterData
            // 
            txtbEnterData.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbEnterData.Location = new Point(195, 114);
            txtbEnterData.Name = "txtbEnterData";
            txtbEnterData.Size = new Size(539, 57);
            txtbEnterData.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(-94, -68);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkList
            // 
            checkList.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkList.FormattingEnabled = true;
            checkList.Location = new Point(153, 249);
            checkList.Name = "checkList";
            checkList.Size = new Size(630, 347);
            checkList.TabIndex = 2;
            checkList.KeyDown += checkList_KeyDown;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(24, 154, 180);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(377, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 57);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 65);
            label1.TabIndex = 4;
            label1.Text = "To Do!";
            // 
            // ToDo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(212, 241, 244);
            ClientSize = new Size(989, 642);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(checkList);
            Controls.Add(checkBox1);
            Controls.Add(txtbEnterData);
            Name = "ToDo";
            Text = "ToDo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbEnterData;
        private CheckBox checkBox1;
        private CheckedListBox checkList;
        private Button btnAdd;
        private Label label1;
    }
}