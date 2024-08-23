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

        private void btnToDO_Click(object sender, EventArgs e)
        {
            ToDo screen  = new ToDo();
            screen.Show();
            this.Hide();
        }
    }
}
