using MaterialSkin;
using MaterialSkin.Controls;
using RomoTimerForm.Controller;
using System;
using System.Windows.Forms;

namespace RomoTimerForm.View
{
    public partial class Login : MaterialForm
    {
        LoginController loginController = new LoginController();

        public static string displayName = "";        //Save username to show the name of registered user
        public static string displayAdminName = "";   //Save admin name to show it in AdminLoggedView.cs


        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;                 //Nuget packet MaterialSkinManager 
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Loginn()
        {
            //Logging into the admin panel or the user panel
            bool isLogged = loginController.IsUserLogged(txtUsername_login.Text, txtPassword_login.Text);
            bool isAdmin = loginController.IsAdmin(txtUsername_login.Text, txtPassword_login.Text);
            //Check for admin
            if (isAdmin == true)
            {
                this.Hide();
                displayAdminName = txtUsername_login.Text; //Take the name of admin
                AdminLoggedView f20 = new AdminLoggedView();
                f20.ShowDialog();
                Close();
            }//Check if user exists
            else if (isLogged == true)
            {
                this.Hide();
                displayName = txtUsername_login.Text;  //Take the name of user
                btnLogout f25 = new btnLogout();
                f25.ShowDialog();
                Close();
            }
            else
            {
                if (txtUsername_login.Text != null)
                {
                    MessageBox.Show("Username and password are not matching");
                }
                else
                {
                    MessageBox.Show("You do not have an account, please register first!");
                }
            }
        }


        private void btnLogin_login_Click(object sender, EventArgs e)
        {
            Loginn();
        }

        private void btnRegisterFirst_Login_Click(object sender, EventArgs e)
        {
            //Go back to register
            this.Hide();
            Register f4 = new Register(this);
            f4.ShowDialog();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void Login_Load(object sender, EventArgs e)
        {
            SettingsController.SavedSettings();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            //Show password
            if (txtPassword_login.PasswordChar == '*')
            {
                btnShowPassword.BringToFront();
                txtPassword_login.PasswordChar = '\0';
                btnShowPassword.Hide();
                btnHidePassword.Show();
            }
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            //Transform password to ********
            if (txtPassword_login.PasswordChar == '\0')
            {
                btnHidePassword.BringToFront();
                txtPassword_login.PasswordChar = '*';
                btnShowPassword.Show();
                btnHidePassword.Hide();
            }
        }
    }
}
