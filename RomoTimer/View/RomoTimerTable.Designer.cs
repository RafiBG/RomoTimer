namespace RomoTimerForm.View
{
    partial class RomoTimerTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.task1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameOfCreatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.romoTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLoggedUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblDisplayUsername = new MaterialSkin.Controls.MaterialLabel();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.MoreToolsRNG = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romoTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTasks
            // 
            this.dgvTasks.AutoGenerateColumns = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.task1DataGridViewTextBoxColumn,
            this.task2DataGridViewTextBoxColumn,
            this.task3DataGridViewTextBoxColumn,
            this.task4DataGridViewTextBoxColumn,
            this.task5DataGridViewTextBoxColumn,
            this.totalTimeDataGridViewTextBoxColumn,
            this.dateOfCreationDataGridViewTextBoxColumn,
            this.usernameOfCreatorDataGridViewTextBoxColumn});
            this.dgvTasks.DataSource = this.romoTaskBindingSource;
            this.dgvTasks.Location = new System.Drawing.Point(21, 147);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(597, 297);
            this.dgvTasks.TabIndex = 0;
            // 
            // task1DataGridViewTextBoxColumn
            // 
            this.task1DataGridViewTextBoxColumn.DataPropertyName = "Task1";
            this.task1DataGridViewTextBoxColumn.HeaderText = "Task 1";
            this.task1DataGridViewTextBoxColumn.Name = "task1DataGridViewTextBoxColumn";
            // 
            // task2DataGridViewTextBoxColumn
            // 
            this.task2DataGridViewTextBoxColumn.DataPropertyName = "Task2";
            this.task2DataGridViewTextBoxColumn.HeaderText = "Task 2";
            this.task2DataGridViewTextBoxColumn.Name = "task2DataGridViewTextBoxColumn";
            // 
            // task3DataGridViewTextBoxColumn
            // 
            this.task3DataGridViewTextBoxColumn.DataPropertyName = "Task3";
            this.task3DataGridViewTextBoxColumn.HeaderText = "Task 3";
            this.task3DataGridViewTextBoxColumn.Name = "task3DataGridViewTextBoxColumn";
            // 
            // task4DataGridViewTextBoxColumn
            // 
            this.task4DataGridViewTextBoxColumn.DataPropertyName = "Task4";
            this.task4DataGridViewTextBoxColumn.HeaderText = "Task 4";
            this.task4DataGridViewTextBoxColumn.Name = "task4DataGridViewTextBoxColumn";
            // 
            // task5DataGridViewTextBoxColumn
            // 
            this.task5DataGridViewTextBoxColumn.DataPropertyName = "Task5";
            this.task5DataGridViewTextBoxColumn.HeaderText = "Task 5";
            this.task5DataGridViewTextBoxColumn.Name = "task5DataGridViewTextBoxColumn";
            // 
            // totalTimeDataGridViewTextBoxColumn
            // 
            this.totalTimeDataGridViewTextBoxColumn.DataPropertyName = "TotalTime";
            this.totalTimeDataGridViewTextBoxColumn.HeaderText = "Total time (hours and minutes)";
            this.totalTimeDataGridViewTextBoxColumn.Name = "totalTimeDataGridViewTextBoxColumn";
            this.totalTimeDataGridViewTextBoxColumn.Width = 95;
            // 
            // dateOfCreationDataGridViewTextBoxColumn
            // 
            this.dateOfCreationDataGridViewTextBoxColumn.DataPropertyName = "DateOfCreation";
            this.dateOfCreationDataGridViewTextBoxColumn.HeaderText = "Date of creation";
            this.dateOfCreationDataGridViewTextBoxColumn.Name = "dateOfCreationDataGridViewTextBoxColumn";
            // 
            // usernameOfCreatorDataGridViewTextBoxColumn
            // 
            this.usernameOfCreatorDataGridViewTextBoxColumn.DataPropertyName = "UsernameOfCreator";
            this.usernameOfCreatorDataGridViewTextBoxColumn.HeaderText = "Creator";
            this.usernameOfCreatorDataGridViewTextBoxColumn.Name = "usernameOfCreatorDataGridViewTextBoxColumn";
            // 
            // romoTaskBindingSource
            // 
            this.romoTaskBindingSource.DataSource = typeof(RomoTimer.Model.RomoTask);
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Depth = 0;
            this.lblLoggedUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoggedUser.Location = new System.Drawing.Point(24, 94);
            this.lblLoggedUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(79, 19);
            this.lblLoggedUser.TabIndex = 62;
            this.lblLoggedUser.Text = "Logged as:";
            // 
            // lblDisplayUsername
            // 
            this.lblDisplayUsername.AutoSize = true;
            this.lblDisplayUsername.Depth = 0;
            this.lblDisplayUsername.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDisplayUsername.Location = new System.Drawing.Point(109, 94);
            this.lblDisplayUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDisplayUsername.Name = "lblDisplayUsername";
            this.lblDisplayUsername.Size = new System.Drawing.Size(82, 19);
            this.lblDisplayUsername.TabIndex = 61;
            this.lblDisplayUsername.Text = "(username)";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(625, 300);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(158, 44);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(625, 233);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(158, 44);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // MoreToolsRNG
            // 
            this.MoreToolsRNG.AutoSize = false;
            this.MoreToolsRNG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoreToolsRNG.BackColor = System.Drawing.SystemColors.Control;
            this.MoreToolsRNG.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MoreToolsRNG.Depth = 0;
            this.MoreToolsRNG.HighEmphasis = true;
            this.MoreToolsRNG.Icon = null;
            this.MoreToolsRNG.Location = new System.Drawing.Point(657, 80);
            this.MoreToolsRNG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MoreToolsRNG.MouseState = MaterialSkin.MouseState.HOVER;
            this.MoreToolsRNG.Name = "MoreToolsRNG";
            this.MoreToolsRNG.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MoreToolsRNG.Size = new System.Drawing.Size(116, 44);
            this.MoreToolsRNG.TabIndex = 64;
            this.MoreToolsRNG.Text = "Go back";
            this.MoreToolsRNG.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MoreToolsRNG.UseAccentColor = false;
            this.MoreToolsRNG.UseVisualStyleBackColor = false;
            this.MoreToolsRNG.Click += new System.EventHandler(this.MoreToolsRNG_Click);
            // 
            // RomoTimerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoreToolsRNG);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.lblDisplayUsername);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvTasks);
            this.MaximizeBox = false;
            this.Name = "RomoTimerTable";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RomoTimer Table";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RomoTimerTable_FormClosed);
            this.Load += new System.EventHandler(this.RomoTimerTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romoTaskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasks;
        private MaterialSkin.Controls.MaterialLabel lblLoggedUser;
        private MaterialSkin.Controls.MaterialLabel lblDisplayUsername;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton MoreToolsRNG;
        private System.Windows.Forms.BindingSource romoTaskBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn task1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn task2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn task3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn task4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn task5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameOfCreatorDataGridViewTextBoxColumn;
    }
}