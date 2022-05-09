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

        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void RandomNumberGenerator_Load_1(object sender, EventArgs e)
        {
            lblDisplayName.Text = Login.displayName;   //Display logged username
            lblNumber.Text = ""; //Hide lblNumber - (result)
            SettingsController.SavedSettings();
        }

        private void MoreToolsRNG_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        public static int RandomNum(int min ,int max)
        {
            Random num = new Random();
            int value = num.Next (min, max + 1);
            return value;
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
                int value = RandomNum(Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtMax.Text));
                lblNumber.Text = value.ToString();
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
