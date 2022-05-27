namespace RomoTimerForm.View
{
    partial class btnLogout
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.btnRomoTimer = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbtnOrange = new MaterialSkin.Controls.MaterialRadioButton();
            this.RbtnGreen = new MaterialSkin.Controls.MaterialRadioButton();
            this.RbtnRed = new MaterialSkin.Controls.MaterialRadioButton();
            this.RbtnBlue = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnCalculator = new MaterialSkin.Controls.MaterialButton();
            this.btnRandomNumber = new MaterialSkin.Controls.MaterialButton();
            this.btnCurrencyConverter = new MaterialSkin.Controls.MaterialButton();
            this.lblDisplayName = new MaterialSkin.Controls.MaterialLabel();
            this.lblLoggedUser = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogoutt = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.ThemeSwitch);
            this.groupBox1.Location = new System.Drawing.Point(22, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 58);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 25);
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
            // btnRomoTimer
            // 
            this.btnRomoTimer.AutoSize = false;
            this.btnRomoTimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRomoTimer.BackColor = System.Drawing.SystemColors.Control;
            this.btnRomoTimer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRomoTimer.Depth = 0;
            this.btnRomoTimer.HighEmphasis = true;
            this.btnRomoTimer.Icon = null;
            this.btnRomoTimer.Location = new System.Drawing.Point(22, 212);
            this.btnRomoTimer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRomoTimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRomoTimer.Name = "btnRomoTimer";
            this.btnRomoTimer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRomoTimer.Size = new System.Drawing.Size(183, 44);
            this.btnRomoTimer.TabIndex = 44;
            this.btnRomoTimer.Text = "RomoTimer";
            this.btnRomoTimer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRomoTimer.UseAccentColor = false;
            this.btnRomoTimer.UseVisualStyleBackColor = false;
            this.btnRomoTimer.Click += new System.EventHandler(this.btnRomoTimer_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbtnOrange);
            this.groupBox2.Controls.Add(this.RbtnGreen);
            this.groupBox2.Controls.Add(this.RbtnRed);
            this.groupBox2.Controls.Add(this.RbtnBlue);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(231, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 173);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Scheme";
            // 
            // RbtnOrange
            // 
            this.RbtnOrange.AutoSize = true;
            this.RbtnOrange.Depth = 0;
            this.RbtnOrange.Location = new System.Drawing.Point(16, 134);
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
            this.RbtnGreen.Location = new System.Drawing.Point(16, 99);
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
            this.RbtnRed.Location = new System.Drawing.Point(16, 62);
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
            // btnCalculator
            // 
            this.btnCalculator.AutoSize = false;
            this.btnCalculator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalculator.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculator.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCalculator.Depth = 0;
            this.btnCalculator.HighEmphasis = true;
            this.btnCalculator.Icon = null;
            this.btnCalculator.Location = new System.Drawing.Point(22, 268);
            this.btnCalculator.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalculator.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCalculator.Size = new System.Drawing.Size(183, 44);
            this.btnCalculator.TabIndex = 51;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCalculator.UseAccentColor = false;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnRandomNumber
            // 
            this.btnRandomNumber.AutoSize = false;
            this.btnRandomNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRandomNumber.BackColor = System.Drawing.SystemColors.Control;
            this.btnRandomNumber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRandomNumber.Depth = 0;
            this.btnRandomNumber.HighEmphasis = true;
            this.btnRandomNumber.Icon = null;
            this.btnRandomNumber.Location = new System.Drawing.Point(22, 324);
            this.btnRandomNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRandomNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRandomNumber.Name = "btnRandomNumber";
            this.btnRandomNumber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRandomNumber.Size = new System.Drawing.Size(183, 58);
            this.btnRandomNumber.TabIndex = 52;
            this.btnRandomNumber.Text = "Random Number Generator";
            this.btnRandomNumber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRandomNumber.UseAccentColor = false;
            this.btnRandomNumber.UseVisualStyleBackColor = false;
            this.btnRandomNumber.Click += new System.EventHandler(this.btnRandomNumber_Click);
            // 
            // btnCurrencyConverter
            // 
            this.btnCurrencyConverter.AutoSize = false;
            this.btnCurrencyConverter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCurrencyConverter.BackColor = System.Drawing.SystemColors.Control;
            this.btnCurrencyConverter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCurrencyConverter.Depth = 0;
            this.btnCurrencyConverter.HighEmphasis = true;
            this.btnCurrencyConverter.Icon = null;
            this.btnCurrencyConverter.Location = new System.Drawing.Point(21, 394);
            this.btnCurrencyConverter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCurrencyConverter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCurrencyConverter.Name = "btnCurrencyConverter";
            this.btnCurrencyConverter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCurrencyConverter.Size = new System.Drawing.Size(183, 58);
            this.btnCurrencyConverter.TabIndex = 53;
            this.btnCurrencyConverter.Text = "Currency Converter (internet)";
            this.btnCurrencyConverter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCurrencyConverter.UseAccentColor = false;
            this.btnCurrencyConverter.UseVisualStyleBackColor = false;
            this.btnCurrencyConverter.Click += new System.EventHandler(this.btnCurrencyConverter_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Depth = 0;
            this.lblDisplayName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDisplayName.Location = new System.Drawing.Point(103, 88);
            this.lblDisplayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(82, 19);
            this.lblDisplayName.TabIndex = 54;
            this.lblDisplayName.Text = "(username)";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Depth = 0;
            this.lblLoggedUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoggedUser.Location = new System.Drawing.Point(18, 88);
            this.lblLoggedUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(79, 19);
            this.lblLoggedUser.TabIndex = 55;
            this.lblLoggedUser.Text = "Logged as:";
            // 
            // btnLogoutt
            // 
            this.btnLogoutt.AutoSize = false;
            this.btnLogoutt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogoutt.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogoutt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogoutt.Depth = 0;
            this.btnLogoutt.HighEmphasis = true;
            this.btnLogoutt.Icon = null;
            this.btnLogoutt.Location = new System.Drawing.Point(247, 74);
            this.btnLogoutt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogoutt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogoutt.Name = "btnLogoutt";
            this.btnLogoutt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogoutt.Size = new System.Drawing.Size(105, 44);
            this.btnLogoutt.TabIndex = 56;
            this.btnLogoutt.Text = "Logout";
            this.btnLogoutt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogoutt.UseAccentColor = false;
            this.btnLogoutt.UseVisualStyleBackColor = false;
            this.btnLogoutt.Click += new System.EventHandler(this.btnLogoutt_Click);
            // 
            // btnLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 509);
            this.Controls.Add(this.btnLogoutt);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.btnCurrencyConverter);
            this.Controls.Add(this.btnRandomNumber);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRomoTimer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "btnLogout";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "More Tools";
            this.Load += new System.EventHandler(this.MoreTools_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSwitch ThemeSwitch;
        private MaterialSkin.Controls.MaterialButton btnRomoTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton RbtnOrange;
        private MaterialSkin.Controls.MaterialRadioButton RbtnGreen;
        private MaterialSkin.Controls.MaterialRadioButton RbtnRed;
        private MaterialSkin.Controls.MaterialRadioButton RbtnBlue;
        private MaterialSkin.Controls.MaterialButton btnCalculator;
        private MaterialSkin.Controls.MaterialButton btnRandomNumber;
        private MaterialSkin.Controls.MaterialButton btnCurrencyConverter;
        private MaterialSkin.Controls.MaterialLabel lblDisplayName;
        private MaterialSkin.Controls.MaterialLabel lblLoggedUser;
        private MaterialSkin.Controls.MaterialButton btnLogoutt;
    }
}