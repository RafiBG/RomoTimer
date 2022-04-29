using MaterialSkin;
using MaterialSkin.Controls;
using RomoTimerForm.Controller;
using System;
using System.Windows.Forms;

namespace RomoTimerForm.View
{
    public partial class RandomNumberGenerator : MaterialForm
    {
        private MaterialForm _parent;

        public RandomNumberGenerator(MaterialForm parent)
        {
            InitializeComponent();
            _parent = parent;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void RandomNumberGenerator_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = Login.displayName;   //Display logged username
            lblNumber.Text = ""; //Hide lblNumber - (result)

            SettingsController settingsController = new SettingsController();
            bool isDarkTheme = settingsController.IsDarkTheme();
            if (isDarkTheme)
            {
                //Check if is dark theme is true set it on dark
                isDarkTheme = true;
                TManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                //Chekc if is dark theme is false set it on light
                isDarkTheme = false;
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

            //Check if is blue scheme is true set it on blue
            bool isBlueScheme = settingsController.IsBlueScheme();
            if (isBlueScheme)
            {
                isBlueScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            }
            //Check if is red scheme is true set it on red
            bool isRedScheme = settingsController.IsRedScheme();
            if (isRedScheme)
            {
                isRedScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Red800,
                Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            }
            //Check if is green scheme is true set it on green
            bool isGreenScheme = settingsController.IsGreenScheme();
            if (isGreenScheme)
            {
                isGreenScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Green800,
                Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
            }
            //Check if is orange scheme is true set it on orange
            bool isOrangeScheme = settingsController.IsOrangeScheme();
            if (isOrangeScheme)
            {
                isOrangeScheme = true;
                TManager.ColorScheme = new ColorScheme(Primary.Orange800,
                Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
            }
        }

        private void MoreToolsRNG_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMin.Text))                          //
            {                                                               //
                MessageBox.Show("Write a valid number in textbox minimum"); //
            }                                                               //  Checks if a number is written.
            else if (String.IsNullOrEmpty(txtMax.Text))                     //
            {                                                               //
                MessageBox.Show("Write a valid number in textbox maximum"); //
            }
            // Check if the minimum number is greater or equal to the maximum number
            else if (Convert.ToInt32(txtMin.Text) >= Convert.ToInt32(txtMax.Text))
            {
                MessageBox.Show("The minimum number cannot be greater or equal to the maximum number");
            }
            else // If all goes well it continues
            {
                Random num = new Random();
                int value = num.Next(Convert.ToInt32(txtMin.Text),
                Convert.ToInt32(txtMax.Text) + 1);
                lblNumber.Text = value.ToString();
            }
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void ThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            lblDisplayName.Text = Login.displayName;

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
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)  //Allows only numbers to be written 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMax_KeyPress(object sender, KeyPressEventArgs e)  //Allows only numbers to be written 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RandomNumberGenerator_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }
    }
}
