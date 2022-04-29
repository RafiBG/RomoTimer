using MaterialSkin;
using MaterialSkin.Controls;
using RomoTimerForm.Controller;
using RomoTimerForm.View;
using System;
using System.Media;
using System.Windows.Forms;
using RomoTimer.View.RomoTimerTasks;
using RomoTimer.Model;
using RomoTimer.Controller;

namespace RomoTimerForm
{
    public partial class RomoTimerView : MaterialForm
    {
        RomoTasksController romoTasksController = new RomoTasksController();
        private SoundPlayer playBeepSound;

        private int sixty = 60;
        private int forty = 40;
        private int timeLeftMinutes;
        private int timeLeftSeconds;
        private int timeLeftMinutesBreak;
        private int timeLeftSecondsBreak;

        private MaterialForm _parent;

        public RomoTimerView(MaterialForm parent)
        {
            InitializeComponent();
            playBeepSound = new SoundPlayer(@"C:\Users\Rafi\Music\Playlists\Three.wav");
            _parent = parent;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MoreToolsRomoTimer_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void btnRomoTimer_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTask1.Text))
            {
                MessageBox.Show("Put task in task 1");
            }
            else if (String.IsNullOrEmpty(txtMinutes.Text))
            {
                MessageBox.Show("Put the time you need to finish task 1");
            }
                int minutes = (Convert.ToInt32(txtMinutes.Text));
                this.timeLeftMinutes = minutes * sixty;
                lblMinutes1.Text = (this.timeLeftMinutes / sixty).ToString("00");
                this.timeLeftSeconds = forty * sixty;
                lblSeconds1.Text = (this.timeLeftSeconds % sixty).ToString("00");

                int hours = minutes / 60;
                int min = minutes % 60;

                RomoTask task = new RomoTask();
                task.Task1 = txtTask1.Text;
                task.DateOfCreation = DateTime.Now;
                task.TotalTime = hours + ": " + min;
                task.UsernameOfCreator = Login.displayName;
                romoTasksController.InsertUser(task);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timeLeftMinutes == 0)
            {
                timer1.Stop();
                playBeepSound.Play();
                MessageBox.Show("Your time is up.");
            }
            else
            {
                this.timeLeftMinutes--;
                this.timeLeftSeconds--;
                lblMinutes1.Text = (this.timeLeftMinutes / sixty).ToString("00");
                lblSeconds1.Text = (this.timeLeftSeconds % sixty).ToString("00");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            lblMinutes1.Text = (this.timeLeftMinutes = 00).ToString("--");
            lblSeconds1.Text = (this.timeLeftSeconds = 00).ToString("--");
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            var taskTable = new RomoTimerTable(this);
            this.Hide();
            taskTable.ShowDialog();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void RomoTimer_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = Login.displayName;   //display logged username

            SettingsController settingsController = new SettingsController();
            bool isDarkTheme = settingsController.IsDarkTheme();
            if (isDarkTheme)
            {
                isDarkTheme = true;
                TManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                isDarkTheme = false;
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

            //check if is BlueScheme is true set it on blue
            bool isBlueScheme = settingsController.IsBlueScheme();
            if (isBlueScheme)
            {
                isBlueScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            }
            //check if is RedScheme is true set it on red
            bool isRedScheme = settingsController.IsRedScheme();
            if (isRedScheme)
            {
                isRedScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Red800,
                Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            }
            //chekc if is GreenScheme is true set it on green
            bool isGreenScheme = settingsController.IsGreenScheme();
            if (isGreenScheme)
            {
                isGreenScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Green800,
                Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
            }
            //chekc if is OrangeScheme is true set it on orange
            bool isOrangeScheme = settingsController.IsOrangeScheme();
            if (isOrangeScheme)
            {
                isOrangeScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Orange800,
                Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
            }
        }

        private void RomoTimerForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _parent.Show();
        }

        private void btnBreakTime_Click(object sender, EventArgs e)
        {
            int breakminutes = (Convert.ToInt32(txtBTMinutes.Text));
            this.timeLeftMinutesBreak = breakminutes * sixty;
            lblBreakMinutes.Text = (this.timeLeftMinutesBreak / sixty).ToString("00");
            this.timeLeftSecondsBreak = forty * sixty;
            lblBreakSeconds.Text = (this.timeLeftSecondsBreak % sixty).ToString("00");
        }

        private void btnBreakStart_Click(object sender, EventArgs e)
        {
            Breaktimer2.Start();
        }

        private void btnBreakStop_Click(object sender, EventArgs e)
        {
            Breaktimer2.Stop();
        }

        private void btnBreakReset_Click(object sender, EventArgs e)
        {
            Breaktimer2.Stop();
            lblBreakMinutes.Text = (this.timeLeftMinutes = 00).ToString("--");
            lblBreakSeconds.Text = (this.timeLeftSeconds = 00).ToString("--");
        }

        private void Breaktimer2_Tick(object sender, EventArgs e)
        {
            if (this.timeLeftMinutesBreak == 0)
            {
                Breaktimer2.Stop();
                playBeepSound.Play();
                MessageBox.Show("Break time is over.");
            }
            else
            {
                this.timeLeftMinutesBreak--;
                this.timeLeftSecondsBreak--;
                lblBreakMinutes.Text = (this.timeLeftMinutesBreak / sixty).ToString("00");
                lblBreakSeconds.Text = (this.timeLeftSecondsBreak % sixty).ToString("00");
            }
        }

        private void txtMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBTMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        internal class Model
        {
            internal class User
            {
            }
        }
    }
}
