using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using RomoTimerForm.Controller;
using RomoTimerForm.View;
using RomoTimer.Model;

namespace RomoTimerForm.View
{
    public partial class Register : MaterialForm
    {
        Form _parent;
        RegisterController registerController = new RegisterController();
        public Register(Form parent)
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

        private void Register_Load(object sender, EventArgs e)
        {

            SettingsController settingsController = new SettingsController();
            bool isDarkTheme = settingsController.IsDarkTheme();
            if (isDarkTheme)
            {
                //isDarkTheme = BitConverter.ToBoolean(TManager.Theme = MaterialSkinManager.Themes.DARK);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Go back to login
            this.Hide();
            Login f4 = new Login();
            f4.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool isRegistered = registerController.IsUserRegistered(txtUsername.Text);
            bool isNotEmpty = registerController.IsNotEmpty(txtUsername.Text, txtFirstName.Text, txtLastName.Text, txtPassword.Text);

            if (txtUsername.Text == string.Empty || txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter valid information!");
            }
            else
            {
                User user = new User();
                user.Username = txtUsername.Text;
                user.First_name = txtFirstName.Text;
                user.Last_name = txtLastName.Text;
                user.Password = txtPassword.Text;
                user.Date_of_creation = DateTime.Today;
                if (isRegistered == true)
                {
                    MessageBox.Show("You are already registered.");
                }
                else if (isRegistered == false)
                {
                    if(isNotEmpty == true)
                    {
                        MessageBox.Show("Enter valid information.");
                    }
                    else
                    {
                        registerController.InsertUser(user);
                        MessageBox.Show("You are registered");

                        this.Hide();
                        Login f1 = new Login();
                        f1.ShowDialog();
                        Close();
                    }
                }
            }

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            //Show password
            if (txtPassword.PasswordChar == '*')
            {
                btnHidePassword.BringToFront();
                txtPassword.PasswordChar = '\0';

                btnShowPassword.Hide();
                btnHidePassword.Show();
            }
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            //Transform password to ********
            if (txtPassword.PasswordChar == '\0')
            {
                btnHidePassword.BringToFront();
                txtPassword.PasswordChar = '*';

                btnShowPassword.Show();
                btnHidePassword.Hide();
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }
    }
}
