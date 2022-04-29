using MaterialSkin;
using MaterialSkin.Controls;
using RomoTimer.Model;
using RomoTimerForm.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RomoTimerForm.View
{
    public partial class AdminLoggedView : MaterialForm

    {
        AdminLoggedController adminLoggedController = new AdminLoggedController();
        public AdminLoggedView()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;         //Nuget packet MaterialSkin
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void RefreshAdminDatabase()
        {
            //Refresh database
            dgvUsers.DataSource = null;
            dgvUsers.Update();
            dgvUsers.Refresh();
            dgvUsers.DataSource = adminLoggedController.GetAllUsers();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        public void AdminLoggedView_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = adminLoggedController.GetAllUsers();
            lblDisplayAdminName.Text = Login.displayAdminName;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //Add user
            User user = new User();
            user.Username = txtAddUsername.Text;
            user.First_name = txtAddFirstName.Text;
            user.Last_name = txtAddLastName.Text;
            user.Password = txtAddPassword.Text;
            user.Date_of_creation = dtAddDateOfCreation.Value;
            adminLoggedController.InsertUser(user);
            MessageBox.Show("You added an user");
            //refreshe the data grid
            RefreshAdminDatabase();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete
            var user = (User)dgvUsers.CurrentRow.DataBoundItem;
            if (user.Id != 0)
            {
                var id = user.Id;
                adminLoggedController.Delete(id);
            }
            RefreshAdminDatabase();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            //Edit
            var user = (User)dgvUsers.CurrentRow.DataBoundItem;
            adminLoggedController.Edit(user);
            RefreshAdminDatabase();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logout
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void ThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeSwitch.Checked)
            {
                TManager.Theme = MaterialSkinManager.Themes.DARK;
                this.dgvUsers.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void RbtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnBlue.Checked == true)
            {
                TManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            }
        }

        private void RbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnRed.Checked == true)
            {
                TManager.ColorScheme = new ColorScheme(Primary.Red800,
                Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            }
        }

        private void RbtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnGreen.Checked == true)
            {
                TManager.ColorScheme = new ColorScheme(Primary.Green800,
                Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
            }
        }

        private void RbtnOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnOrange.Checked == true)
            {
                TManager.ColorScheme = new ColorScheme(Primary.Orange800,
                Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
            }
        }
    }
}
