using MaterialSkin;
using MaterialSkin.Controls;
using RomoTimerForm.Controller;
using RomoTimerForm.View;
using System;
using System.Windows.Forms;
using RomoTimerForm;

namespace RomoTimer.View.RomoTimerTasks
{
    public partial class HowManyTasks : MaterialForm
    {
        private MaterialForm _parent;
        public HowManyTasks(MaterialForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void HowManyTasks_Load(object sender, EventArgs e)
        {
            SettingsController.SavedSettings();
        }

        private void HowManyTasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }

        private void btnTasks1_Click(object sender, EventArgs e)
        {
            var rmtt1 = new RomoTimerView(this);
            this.Hide();
            rmtt1.ShowDialog();
        }

        private void MoreToolsRomoTimer1_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void btnTasks2_Click(object sender, EventArgs e)
        {
            var romoTask2 = new RomoTimerTasks2(this);
            this.Hide();
            romoTask2.ShowDialog();
        }

        private void btnTasks3_Click(object sender, EventArgs e)
        {
            var romoTasks3 = new RomoTimerTasks3(this);
            this.Hide();
            romoTasks3.ShowDialog();
        }

        private void btnTasks4_Click(object sender, EventArgs e)
        {
            var romoTasks4 = new RomoTimerTasks4(this);
            this.Hide();
            romoTasks4.ShowDialog();
        }

        private void btnTasks5_Click(object sender, EventArgs e)
        {
            var romoTasks5 = new RomoTimerTasks5(this);
            this.Hide();
            romoTasks5.ShowDialog();
        }
    }
}
