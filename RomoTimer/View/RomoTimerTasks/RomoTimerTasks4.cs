using MaterialSkin;
using MaterialSkin.Controls;
using RomoTimer.Controller;
using RomoTimer.Model;
using RomoTimerForm.Controller;
using RomoTimerForm.View;
using System;
using System.Windows.Forms;

namespace RomoTimer.View.RomoTimerTasks
{
    public partial class RomoTimerTasks4 : MaterialForm
    {
        RomoTasksController romoTasksController = new RomoTasksController();

        private int sixty = 60;
        private int forty = 40;
        private int timeLeftMinutes;
        private int timeLeftSeconds;
        private int timeLeftMinutes2;
        private int timeLeftSeconds2;
        private int timeLeftMinutes3;
        private int timeLeftSeconds3;
        private int timeLeftMinutes4;
        private int timeLeftSeconds4;   
        private int timeLeftMinutesBreak;
        private int timeLeftSecondsBreak;

        private MaterialForm _parent;
        public RomoTimerTasks4(MaterialForm parent)
        {
            InitializeComponent();

            RomoTimerController.BeepSoundDirectory();
            _parent = parent;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void RomoTimerTasks4_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = Login.displayName;   //display logged username
            SettingsController.SavedSettings();
        }

        private void RomoTimerTasks4_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }

        private void MoreToolsRomoTimer1_Click(object sender, EventArgs e)
        {
            this.Close();
            MoreToolsRomoTimer1.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            var taskTable = new RomoTimerTable(this);
            this.Hide();
            taskTable.ShowDialog();
        }

        private void btnRomoTimer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTask1.Text))
            {
                MessageBox.Show("Put task in task 1");
            }
            else if (String.IsNullOrEmpty(txtTask2.Text))
            {
                MessageBox.Show("Put task in task 2");
            }
            else if (String.IsNullOrEmpty(txtMinutes.Text))
            {
                MessageBox.Show("Put the time you need to finish task 1");
            }
            else if (String.IsNullOrEmpty(txtMinutes2.Text))
            {
                MessageBox.Show("Put the time you need to finish task 2");
            }
            else if (String.IsNullOrEmpty(txtTask3.Text))
            {
                MessageBox.Show("Put task in task 3");
            }
            else if (String.IsNullOrEmpty(txtMinutes3.Text))
            {
                MessageBox.Show("Put the time you need to finish task 3");
            }
            else if (String.IsNullOrEmpty(txtTask4.Text))
            {
                MessageBox.Show("Put task in task 4");
            }
            else if (String.IsNullOrEmpty(txtMinutes4.Text))
            {
                MessageBox.Show("Put the time you need to finish task 4");
            }
            else
            {
                int minutes = (Convert.ToInt32(txtMinutes.Text));
                this.timeLeftMinutes = minutes * sixty;
                lblMinutes1.Text = (this.timeLeftMinutes / sixty).ToString("00");
                this.timeLeftSeconds = forty * sixty;
                lblSeconds1.Text = (this.timeLeftSeconds % sixty).ToString("00");

                int minutes2 = (Convert.ToInt32(txtMinutes2.Text));
                this.timeLeftMinutes2 = minutes2 * sixty;
                lblMinutes2.Text = (this.timeLeftMinutes2 / sixty).ToString("00");
                this.timeLeftSeconds2 = forty * sixty;
                lblSeconds2.Text = (this.timeLeftSeconds2 % sixty).ToString("00");

                int minutes3 = (Convert.ToInt32(txtMinutes3.Text));
                this.timeLeftMinutes3 = minutes3 * sixty;
                lblMinutes3.Text = (this.timeLeftMinutes3 / sixty).ToString("00");
                this.timeLeftSeconds3 = forty * sixty;
                lblSeconds3.Text = (this.timeLeftSeconds3 % sixty).ToString("00");

                int minutes4 = (Convert.ToInt32(txtMinutes4.Text));
                this.timeLeftMinutes4 = minutes4 * sixty;
                lblMinutes4.Text = (this.timeLeftMinutes4 / sixty).ToString("00");
                this.timeLeftSeconds4 = forty * sixty;
                lblSeconds4.Text = (this.timeLeftSeconds4 % sixty).ToString("00");

                int totalTime = minutes + minutes2 + minutes3 + minutes4;
                int hours = totalTime / 60;
                int min = totalTime % 60;

                RomoTask task = new RomoTask();
                task.Task1 = txtTask1.Text;
                task.Task2 = txtTask2.Text;
                task.Task3 = txtTask3.Text;
                task.Task4 = txtTask4.Text;
                task.TotalTime = hours + ": " + min;
                task.DateOfCreation = DateTime.Now;
                task.UsernameOfCreator = Login.displayName;
                romoTasksController.InsertUser(task);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblMinutes1.Text = (this.timeLeftMinutes = 00).ToString("--");
            lblSeconds1.Text = (this.timeLeftSeconds = 00).ToString("--");
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            lblMinutes2.Text = (this.timeLeftMinutes = 00).ToString("--");
            lblSeconds2.Text = (this.timeLeftSeconds = 00).ToString("--");
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            lblMinutes3.Text = (this.timeLeftMinutes = 00).ToString("--");
            lblSeconds3.Text = (this.timeLeftSeconds = 00).ToString("--");
        }

        private void btnStart4_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void btnStop4_Click(object sender, EventArgs e)
        {
            timer4.Stop();
        }

        private void btnReset4_Click(object sender, EventArgs e)
        {
            timer4.Stop();
            lblMinutes4.Text = (this.timeLeftMinutes = 00).ToString("--");
            lblSeconds4.Text = (this.timeLeftSeconds = 00).ToString("--");
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
            lblBreakMinutes.Text = (this.timeLeftMinutes = 00).ToString("00");
            lblBreakSeconds.Text = (this.timeLeftSeconds = 00).ToString("00");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timeLeftMinutes == 0)
            {
                timer1.Stop();
                RomoTimerController.PlayBeepSound();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.timeLeftMinutes == 0)
            {
                timer2.Stop();
                RomoTimerController.PlayBeepSound();
                MessageBox.Show("Your time is up.");
            }
            else
            {
                this.timeLeftMinutes2--;
                this.timeLeftSeconds2--;
                lblMinutes2.Text = (this.timeLeftMinutes2 / sixty).ToString("00");
                lblSeconds2.Text = (this.timeLeftSeconds2 % sixty).ToString("00");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.timeLeftMinutes == 0)
            {
                timer3.Stop();
                RomoTimerController.PlayBeepSound();
                MessageBox.Show("Your time is up.");
            }
            else
            {
                this.timeLeftMinutes3--;
                this.timeLeftSeconds3--;
                lblMinutes3.Text = (this.timeLeftMinutes3 / sixty).ToString("00");
                lblSeconds3.Text = (this.timeLeftSeconds3 % sixty).ToString("00");
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (this.timeLeftMinutes4 == 0)
            {
                timer4.Stop();
                RomoTimerController.PlayBeepSound();
                MessageBox.Show("Your time is up.");
            }
            else
            {
                this.timeLeftMinutes4--;
                this.timeLeftSeconds4--;
                lblMinutes4.Text = (this.timeLeftMinutes4 / sixty).ToString("00");
                lblSeconds4.Text = (this.timeLeftSeconds4 % sixty).ToString("00");
            }
        }

        private void Breaktimer2_Tick(object sender, EventArgs e)
        {
            if (this.timeLeftMinutesBreak == 0)
            {
                Breaktimer2.Stop();
                RomoTimerController.PlayBeepSound();
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

        private void txtMinutes2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMinutes3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMinutes4_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
