using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string text = txtbEnterData.Text;
            checkList.Items.Add(text);
            txtbEnterData.Text = "";
        }

        private void checkList_KeyDown(object sender, KeyEventArgs e)
        {
            if(Convert.ToInt32(e.KeyCode) == 13)
            {
                checkList.Items.Add(txtbEnterData.Text);
                txtbEnterData.Text = "";

            }
        }
    }
}
