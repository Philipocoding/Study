namespace Study
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            PomodoroScreen pomodoro = new PomodoroScreen();
            this.Hide();
            pomodoro.Show();
            pomodoro.BringToFront();
        }
    }
}
