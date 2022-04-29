using MaterialSkin;
using MaterialSkin.Controls;
using RomoTimer.Controller;
using RomoTimer.Model;
using RomoTimer.View.RomoTimerTasks;
using RomoTimerForm.Controller;
using System;
using System.Drawing;

namespace RomoTimerForm.View
{
    public partial class RomoTimerTable : MaterialForm
    {
        RomoTasksController romoTaskController = new RomoTasksController();

        private MaterialForm _parent;
        public RomoTimerTable(MaterialForm parent)
        {
            InitializeComponent();
            _parent = parent;

            var materialSkinManager = MaterialSkinManager.Instance;         //Nuget packet MaterialSkin
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800,
                Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void RefreshTasksDatabase()
        {
            //Refreshes datatable
            dgvTasks.DataSource = null;
            dgvTasks.Update();
            dgvTasks.Refresh();
            dgvTasks.DataSource = romoTaskController.GetAllUsers();
        }
        private void btnRomoTimer_Click(object sender, EventArgs e)
        {
            //new RomoTimerForm().Show();
            //this.Hide();
        }

         MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void RomoTimerTable_Load(object sender, EventArgs e)
        {
            lblDisplayUsername.Text = Login.displayName;   //display logged username
            dgvTasks.DataSource = romoTaskController.GetAllUsers();

            SettingsController settingsController = new SettingsController();
            bool isDarkTheme = settingsController.IsDarkTheme();
            if (isDarkTheme)
            {
                isDarkTheme = true;
                TManager.Theme = MaterialSkinManager.Themes.DARK;
                this.dgvTasks.DefaultCellStyle.ForeColor = Color.Black;
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

        private void RomoTimerTable_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _parent.Show();
        }

        private void MoreToolsRNG_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Edit
            var romotask = (RomoTask)dgvTasks.CurrentRow.DataBoundItem;
            romoTaskController.Edit(romotask);
            RefreshTasksDatabase();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete
            var romotask = (RomoTask)dgvTasks.CurrentRow.DataBoundItem;
            if (romotask.Id != 0)
            {
                var id = romotask.Id;
                romoTaskController.Delete(id);
            }
            RefreshTasksDatabase();
        }
    }
}
