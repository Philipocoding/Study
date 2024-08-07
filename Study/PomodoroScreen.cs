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
    public partial class PomodoroScreen : Form
    {
        public PomodoroScreen()
        {
            InitializeComponent();
        }

        private void PomodoroScreen_Load(object sender, EventArgs e)
        {
            lblTimer.Text = Timer.Time.ToString();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            Timer.Time++;
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {

        }
    }
}
