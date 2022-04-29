using RomoTimer.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomoTimer
{
    public partial class RomoTimer : Form
    {
        private int timeLeftHours;
        private int timeLeftMinutes;
        private int timeLeftSeconds;
        public RomoTimer()
        {
            InitializeComponent();
        }

        private void MoreToolsRomoTimer_Click(object sender, EventArgs e)
        {
            new MoreTools().Show();
            this.Hide();
        }

        private void btnRomoTimer_Click(object sender, EventArgs e)
        {
            //this.timeLeftHours = 1;
            //lblHours.Text = this.timeLeftHours.ToString("00");

            this.timeLeftMinutes = 25 * 60;
            lblMinutes.Text = this.timeLeftMinutes.ToString("00");

            this.timeLeftSeconds = 40 * 60;
            lblSeconds.Text = this.timeLeftSeconds.ToString("00");
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            this.timeLeftHours --;
            this.timeLeftMinutes --;
            this.timeLeftSeconds --;
            lblMinutes.Text = (this.timeLeftMinutes / 60).ToString("00");
            lblSeconds.Text = (this.timeLeftSeconds % 60).ToString("00");

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
            //lblHours.Text = (this.timeLeftHours).ToString("00");
            lblMinutes.Text = (this.timeLeftMinutes = 00).ToString("00");
            lblSeconds.Text = (this.timeLeftSeconds = 00).ToString("00");


        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            new RomoTimerTable().Show();
            this.Hide();
        }
    }
}
