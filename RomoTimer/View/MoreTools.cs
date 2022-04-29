using MaterialSkin;
using MaterialSkin.Controls;
using System;
using RomoTimerForm.Controller;
using RomoTimerForm.Properties;
using RomoTimer.View;
using RomoTimer.View.RomoTimerTasks;

namespace RomoTimerForm.View
{
    public partial class btnLogout : MaterialForm
    {

        private MaterialForm _parent;

        public btnLogout()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnRomoTimer_Click_1(object sender, EventArgs e)
        {
            var hmt = new HowManyTasks(this);
            this.Hide();
            hmt.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            var calculator = new Calculator(this);
            this.Hide();
            calculator.ShowDialog();
        }

        private void btnRandomNumber_Click(object sender, EventArgs e)
        {
           var random = new RandomNumberGenerator(this);
            this.Hide();
            random.ShowDialog();
        }

        private void btnCurrencyConverter_Click(object sender, EventArgs e)
        {
            var converter = new CurrencyConverter(this);
            this.Hide();
            converter.ShowDialog();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void ThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            if (ThemeSwitch.Checked)
            {
                TManager.Theme = MaterialSkinManager.Themes.DARK;
                settings.IsDarkTheme = true;
                SettingsController settingsController = new SettingsController();
                settingsController.SetTheme(true);
            }
            else
            {
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
                SettingsController settingsController = new SettingsController();
                settingsController.SetTheme(false);
            }
        }

        private void RbtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            if (RbtnBlue.Checked == true)
            {
                TManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
                settings.IsBlueScheme = true;
                SettingsController settingsController = new SettingsController();
                settingsController.SetBlueScheme(true);
                settingsController.SetRedScheme(false);
                settingsController.SetGreenScheme(false);
                settingsController.SetOrangeScheme(false);
            }
        }

        private void RbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            if (RbtnRed.Checked == true)
            {
                TManager.ColorScheme = new ColorScheme(Primary.Red800,
                Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
                settings.IsRedScheme = true;
                SettingsController settingsController = new SettingsController();
                settingsController.SetRedScheme(true);
                settingsController.SetBlueScheme (false);
                settingsController.SetGreenScheme(false);
                settingsController.SetOrangeScheme(false);
            } 
        }

        private void RbtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            if (RbtnGreen.Checked == true)
            {
                TManager.ColorScheme = new ColorScheme(Primary.Green800,
                Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
                settings.IsGreenScheme = true;
                SettingsController settingsController = new SettingsController();
                settingsController.SetGreenScheme(true);
                settingsController.SetBlueScheme(false);
                settingsController.SetRedScheme(false);
                settingsController.SetOrangeScheme(false);
            } 
        }

        private void RbtnOrange_CheckedChanged(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            if (RbtnOrange.Checked == true)
            {
                TManager.ColorScheme = new ColorScheme(Primary.Orange800,
                Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
                settings.IsOrangeScheme = true;
                SettingsController settingsController = new SettingsController();
                settingsController.SetOrangeScheme(true);
                settingsController.SetBlueScheme(false);
                settingsController.SetGreenScheme(false);
                settingsController.SetRedScheme(false);
            } 
        }


        private void MoreTools_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = Login.displayName; // display logged user in MoreTools
            SettingsController.SavedSettings();
        }

        private void btnLogoutt_Click(object sender, EventArgs e)
        {
            //Logout
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }
    }
}
