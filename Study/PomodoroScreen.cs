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
        public void updateTime()
        {
            if(Timer.start)
            {
                if (Timer.Seconds == 0)
                {
                    Timer.Seconds = 59;
                    Timer.Minutes = Timer.Minutes - 1;
                }
                else
                {
                    Timer.Seconds = Timer.Seconds - 1;
                }
                pnlTimer.Width+=20;
            }
            string text = "";
            if(Timer.Seconds.ToString().Length == 1)
            {
                text = Timer.Minutes.ToString() + ":0" + Timer.Seconds.ToString();

            }
            else
            {
                text = Timer.Minutes.ToString() + ":" + Timer.Seconds.ToString();
            }
            pnlTimer.Width = 0;
            lblTimer.Text = text;
        }
        public PomodoroScreen()
        {
            InitializeComponent();
        }

        private void PomodoroScreen_Load(object sender, EventArgs e)
        {
            updateTime();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            Timer.Minutes = Timer.Minutes + 1;
            updateTime();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            Timer.Minutes = Timer.Minutes - 1;
            updateTime();

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime(1, 1, 1, 1, Timer.Minutes, Timer.Seconds);
            Timer.start = true;
            PomodoroTimer.Start();
        }

        private void PomodoroTimer_Tick(object sender, EventArgs e)
        {
            updateTime();
        }
    }
}
