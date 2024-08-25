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

        public void TimeOff()
        {
            
            lblTimer.Text = "5:00";
            pnlComplete.Visible = true;
            Timer.Minutes = 5;
            Timer.Seconds = 0;
            PomodoroTimer.Start();
            updateTime();
            
        }
        public void updateTime()
        {
            if (Timer.start)
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
                if ((Timer.Minutes == 0) && (Timer.Seconds == 0))
                {
                    Timer.start = false;
                    PomodoroTimer.Stop();
                    if (Timer.nextState == 0)
                    {
                        Timer.nextState = 1;
                        TimeOff();

                    }
                    else
                    {
                        Timer.nextState = 1;
                        Timer.Minutes = 25;
                        Timer.Seconds = 0;
                        pnlComplete.Visible = false;


                    }

                }
                pnlIncrease.Width += 20;
            }
            
            pnlIncrease.Width = 0;
            lblTimer.Text = Timer.Formatting();
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
            pnlIncrease.Width += 20;
            updateTime();

        }
    }
}
