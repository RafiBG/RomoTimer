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
            SettingsController.SavedSettings();
            this.dgvTasks.DefaultCellStyle.ForeColor = Color.Black;
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
