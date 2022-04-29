namespace RomoTimerForm.View
{
    partial class AdminLoggedView
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
            this.txtAddUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtAddFirstName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtAddPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dtAddDateOfCreation = new System.Windows.Forms.DateTimePicker();
            this.txtAddLastName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.lblLoggedUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblDisplayAdminName = new MaterialSkin.Controls.MaterialLabel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbtnOrange = new MaterialSkin.Controls.MaterialRadioButton();
            this.RbtnGreen = new MaterialSkin.Controls.MaterialRadioButton();
            this.RbtnRed = new MaterialSkin.Controls.MaterialRadioButton();
            this.RbtnBlue = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.AllowPromptAsInput = true;
            this.txtAddUsername.AnimateReadOnly = false;
            this.txtAddUsername.AsciiOnly = false;
            this.txtAddUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddUsername.BeepOnError = false;
            this.txtAddUsername.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddUsername.Depth = 0;
            this.txtAddUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddUsername.HidePromptOnLeave = false;
            this.txtAddUsername.HideSelection = true;
            this.txtAddUsername.Hint = "Username";
            this.txtAddUsername.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtAddUsername.LeadingIcon = null;
            this.txtAddUsername.Location = new System.Drawing.Point(34, 93);
            this.txtAddUsername.Mask = "";
            this.txtAddUsername.MaxLength = 32767;
            this.txtAddUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.PasswordChar = '\0';
            this.txtAddUsername.PrefixSuffixText = null;
            this.txtAddUsername.PromptChar = '_';
            this.txtAddUsername.ReadOnly = false;
            this.txtAddUsername.RejectInputOnFirstFailure = false;
            this.txtAddUsername.ResetOnPrompt = true;
            this.txtAddUsername.ResetOnSpace = true;
            this.txtAddUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddUsername.SelectedText = "";
            this.txtAddUsername.SelectionLength = 0;
            this.txtAddUsername.SelectionStart = 0;
            this.txtAddUsername.ShortcutsEnabled = true;
            this.txtAddUsername.Size = new System.Drawing.Size(221, 48);
            this.txtAddUsername.SkipLiterals = true;
            this.txtAddUsername.TabIndex = 4;
            this.txtAddUsername.TabStop = false;
            this.txtAddUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddUsername.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddUsername.TrailingIcon = null;
            this.txtAddUsername.UseSystemPasswordChar = false;
            this.txtAddUsername.ValidatingType = null;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.AllowPromptAsInput = true;
            this.txtAddFirstName.AnimateReadOnly = false;
            this.txtAddFirstName.AsciiOnly = false;
            this.txtAddFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddFirstName.BeepOnError = false;
            this.txtAddFirstName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddFirstName.Depth = 0;
            this.txtAddFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddFirstName.HidePromptOnLeave = false;
            this.txtAddFirstName.HideSelection = true;
            this.txtAddFirstName.Hint = "First name";
            this.txtAddFirstName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtAddFirstName.LeadingIcon = null;
            this.txtAddFirstName.Location = new System.Drawing.Point(34, 157);
            this.txtAddFirstName.Mask = "";
            this.txtAddFirstName.MaxLength = 32767;
            this.txtAddFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.PasswordChar = '\0';
            this.txtAddFirstName.PrefixSuffixText = null;
            this.txtAddFirstName.PromptChar = '_';
            this.txtAddFirstName.ReadOnly = false;
            this.txtAddFirstName.RejectInputOnFirstFailure = false;
            this.txtAddFirstName.ResetOnPrompt = true;
            this.txtAddFirstName.ResetOnSpace = true;
            this.txtAddFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddFirstName.SelectedText = "";
            this.txtAddFirstName.SelectionLength = 0;
            this.txtAddFirstName.SelectionStart = 0;
            this.txtAddFirstName.ShortcutsEnabled = true;
            this.txtAddFirstName.Size = new System.Drawing.Size(221, 48);
            this.txtAddFirstName.SkipLiterals = true;
            this.txtAddFirstName.TabIndex = 5;
            this.txtAddFirstName.TabStop = false;
            this.txtAddFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddFirstName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddFirstName.TrailingIcon = null;
            this.txtAddFirstName.UseSystemPasswordChar = false;
            this.txtAddFirstName.ValidatingType = null;
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.AllowPromptAsInput = true;
            this.txtAddPassword.AnimateReadOnly = false;
            this.txtAddPassword.AsciiOnly = false;
            this.txtAddPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddPassword.BeepOnError = false;
            this.txtAddPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddPassword.Depth = 0;
            this.txtAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddPassword.HidePromptOnLeave = false;
            this.txtAddPassword.HideSelection = true;
            this.txtAddPassword.Hint = "Password";
            this.txtAddPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtAddPassword.LeadingIcon = null;
            this.txtAddPassword.Location = new System.Drawing.Point(34, 293);
            this.txtAddPassword.Mask = "";
            this.txtAddPassword.MaxLength = 32767;
            this.txtAddPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.PasswordChar = '\0';
            this.txtAddPassword.PrefixSuffixText = null;
            this.txtAddPassword.PromptChar = '_';
            this.txtAddPassword.ReadOnly = false;
            this.txtAddPassword.RejectInputOnFirstFailure = false;
            this.txtAddPassword.ResetOnPrompt = true;
            this.txtAddPassword.ResetOnSpace = true;
            this.txtAddPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddPassword.SelectedText = "";
            this.txtAddPassword.SelectionLength = 0;
            this.txtAddPassword.SelectionStart = 0;
            this.txtAddPassword.ShortcutsEnabled = true;
            this.txtAddPassword.Size = new System.Drawing.Size(221, 48);
            this.txtAddPassword.SkipLiterals = true;
            this.txtAddPassword.TabIndex = 6;
            this.txtAddPassword.TabStop = false;
            this.txtAddPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddPassword.TrailingIcon = null;
            this.txtAddPassword.UseSystemPasswordChar = false;
            this.txtAddPassword.ValidatingType = null;
            // 
            // dtAddDateOfCreation
            // 
            this.dtAddDateOfCreation.Location = new System.Drawing.Point(34, 359);
            this.dtAddDateOfCreation.Name = "dtAddDateOfCreation";
            this.dtAddDateOfCreation.Size = new System.Drawing.Size(221, 20);
            this.dtAddDateOfCreation.TabIndex = 7;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.AllowPromptAsInput = true;
            this.txtAddLastName.AnimateReadOnly = false;
            this.txtAddLastName.AsciiOnly = false;
            this.txtAddLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddLastName.BeepOnError = false;
            this.txtAddLastName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddLastName.Depth = 0;
            this.txtAddLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddLastName.HidePromptOnLeave = false;
            this.txtAddLastName.HideSelection = true;
            this.txtAddLastName.Hint = "Last name";
            this.txtAddLastName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtAddLastName.LeadingIcon = null;
            this.txtAddLastName.Location = new System.Drawing.Point(34, 231);
            this.txtAddLastName.Mask = "";
            this.txtAddLastName.MaxLength = 32767;
            this.txtAddLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.PasswordChar = '\0';
            this.txtAddLastName.PrefixSuffixText = null;
            this.txtAddLastName.PromptChar = '_';
            this.txtAddLastName.ReadOnly = false;
            this.txtAddLastName.RejectInputOnFirstFailure = false;
            this.txtAddLastName.ResetOnPrompt = true;
            this.txtAddLastName.ResetOnSpace = true;
            this.txtAddLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddLastName.SelectedText = "";
            this.txtAddLastName.SelectionLength = 0;
            this.txtAddLastName.SelectionStart = 0;
            this.txtAddLastName.ShortcutsEnabled = true;
            this.txtAddLastName.Size = new System.Drawing.Size(221, 48);
            this.txtAddLastName.SkipLiterals = true;
            this.txtAddLastName.TabIndex = 8;
            this.txtAddLastName.TabStop = false;
            this.txtAddLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddLastName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddLastName.TrailingIcon = null;
            this.txtAddLastName.UseSystemPasswordChar = false;
            this.txtAddLastName.ValidatingType = null;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(382, 198);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(168, 44);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
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
            this.btnEdit.Location = new System.Drawing.Point(382, 267);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(168, 44);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
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
            this.btnDelete.Location = new System.Drawing.Point(382, 335);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(168, 44);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Depth = 0;
            this.lblLoggedUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoggedUser.Location = new System.Drawing.Point(441, 97);
            this.lblLoggedUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(79, 19);
            this.lblLoggedUser.TabIndex = 57;
            this.lblLoggedUser.Text = "Logged as:";
            // 
            // lblDisplayAdminName
            // 
            this.lblDisplayAdminName.AutoSize = true;
            this.lblDisplayAdminName.Depth = 0;
            this.lblDisplayAdminName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDisplayAdminName.Location = new System.Drawing.Point(528, 97);
            this.lblDisplayAdminName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDisplayAdminName.Name = "lblDisplayAdminName";
            this.lblDisplayAdminName.Size = new System.Drawing.Size(82, 19);
            this.lblDisplayAdminName.TabIndex = 56;
            this.lblDisplayAdminName.Text = "(username)";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn68,
            this.dataGridViewTextBoxColumn69,
            this.dataGridViewTextBoxColumn70,
            this.dataGridViewTextBoxColumn71,
            this.dataGridViewTextBoxColumn72});
            this.dgvUsers.DataSource = this.userBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(92, 408);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(643, 197);
            this.dgvUsers.TabIndex = 58;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(659, 83);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(105, 44);
            this.btnLogout.TabIndex = 59;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbtnOrange);
            this.groupBox2.Controls.Add(this.RbtnGreen);
            this.groupBox2.Controls.Add(this.RbtnRed);
            this.groupBox2.Controls.Add(this.RbtnBlue);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(593, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 125);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Scheme";
            // 
            // RbtnOrange
            // 
            this.RbtnOrange.AutoSize = true;
            this.RbtnOrange.Depth = 0;
            this.RbtnOrange.Location = new System.Drawing.Point(101, 77);
            this.RbtnOrange.Margin = new System.Windows.Forms.Padding(0);
            this.RbtnOrange.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbtnOrange.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbtnOrange.Name = "RbtnOrange";
            this.RbtnOrange.Ripple = true;
            this.RbtnOrange.Size = new System.Drawing.Size(86, 37);
            this.RbtnOrange.TabIndex = 3;
            this.RbtnOrange.TabStop = true;
            this.RbtnOrange.Text = "Orange";
            this.RbtnOrange.UseVisualStyleBackColor = true;
            this.RbtnOrange.CheckedChanged += new System.EventHandler(this.RbtnOrange_CheckedChanged);
            // 
            // RbtnGreen
            // 
            this.RbtnGreen.AutoSize = true;
            this.RbtnGreen.Depth = 0;
            this.RbtnGreen.Location = new System.Drawing.Point(11, 77);
            this.RbtnGreen.Margin = new System.Windows.Forms.Padding(0);
            this.RbtnGreen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbtnGreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbtnGreen.Name = "RbtnGreen";
            this.RbtnGreen.Ripple = true;
            this.RbtnGreen.Size = new System.Drawing.Size(76, 37);
            this.RbtnGreen.TabIndex = 2;
            this.RbtnGreen.TabStop = true;
            this.RbtnGreen.Text = "Green";
            this.RbtnGreen.UseVisualStyleBackColor = true;
            this.RbtnGreen.CheckedChanged += new System.EventHandler(this.RbtnGreen_CheckedChanged);
            // 
            // RbtnRed
            // 
            this.RbtnRed.AutoSize = true;
            this.RbtnRed.Depth = 0;
            this.RbtnRed.Location = new System.Drawing.Point(101, 26);
            this.RbtnRed.Margin = new System.Windows.Forms.Padding(0);
            this.RbtnRed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbtnRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbtnRed.Name = "RbtnRed";
            this.RbtnRed.Ripple = true;
            this.RbtnRed.Size = new System.Drawing.Size(62, 37);
            this.RbtnRed.TabIndex = 1;
            this.RbtnRed.TabStop = true;
            this.RbtnRed.Text = "Red";
            this.RbtnRed.UseVisualStyleBackColor = true;
            this.RbtnRed.CheckedChanged += new System.EventHandler(this.RbtnRed_CheckedChanged);
            // 
            // RbtnBlue
            // 
            this.RbtnBlue.AutoSize = true;
            this.RbtnBlue.Depth = 0;
            this.RbtnBlue.Location = new System.Drawing.Point(16, 25);
            this.RbtnBlue.Margin = new System.Windows.Forms.Padding(0);
            this.RbtnBlue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbtnBlue.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbtnBlue.Name = "RbtnBlue";
            this.RbtnBlue.Ripple = true;
            this.RbtnBlue.Size = new System.Drawing.Size(66, 37);
            this.RbtnBlue.TabIndex = 0;
            this.RbtnBlue.TabStop = true;
            this.RbtnBlue.Text = "Blue";
            this.RbtnBlue.UseVisualStyleBackColor = true;
            this.RbtnBlue.CheckedChanged += new System.EventHandler(this.RbtnBlue_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.ThemeSwitch);
            this.groupBox1.Location = new System.Drawing.Point(597, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 58);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "Theme";
            // 
            // ThemeSwitch
            // 
            this.ThemeSwitch.AutoSize = true;
            this.ThemeSwitch.Depth = 0;
            this.ThemeSwitch.Location = new System.Drawing.Point(76, 16);
            this.ThemeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.ThemeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeSwitch.Name = "ThemeSwitch";
            this.ThemeSwitch.Ripple = true;
            this.ThemeSwitch.Size = new System.Drawing.Size(91, 37);
            this.ThemeSwitch.TabIndex = 39;
            this.ThemeSwitch.Text = "Dark";
            this.ThemeSwitch.UseVisualStyleBackColor = true;
            this.ThemeSwitch.CheckedChanged += new System.EventHandler(this.ThemeSwitch_CheckedChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(RomoTimer.Model.User);
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn68.HeaderText = "Username";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.Width = 120;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "First_name";
            this.dataGridViewTextBoxColumn69.HeaderText = "First name";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.Width = 120;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "Last_name";
            this.dataGridViewTextBoxColumn70.HeaderText = "Last name";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.Width = 120;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn71.HeaderText = "Password";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.Width = 120;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "Date_of_creation";
            this.dataGridViewTextBoxColumn72.HeaderText = "Date of creation";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.Width = 120;
            // 
            // AdminLoggedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 635);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.lblDisplayAdminName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddLastName);
            this.Controls.Add(this.dtAddDateOfCreation);
            this.Controls.Add(this.txtAddPassword);
            this.Controls.Add(this.txtAddFirstName);
            this.Controls.Add(this.txtAddUsername);
            this.MaximizeBox = false;
            this.Name = "AdminLoggedView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Control Panel";
            this.Load += new System.EventHandler(this.AdminLoggedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAddUsername;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAddFirstName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAddPassword;
        private System.Windows.Forms.DateTimePicker dtAddDateOfCreation;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAddLastName;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofcreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private MaterialSkin.Controls.MaterialLabel lblLoggedUser;
        private MaterialSkin.Controls.MaterialLabel lblDisplayAdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridView dgvUsers;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton RbtnOrange;
        private MaterialSkin.Controls.MaterialRadioButton RbtnGreen;
        private MaterialSkin.Controls.MaterialRadioButton RbtnRed;
        private MaterialSkin.Controls.MaterialRadioButton RbtnBlue;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSwitch ThemeSwitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
    }
}