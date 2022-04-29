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
