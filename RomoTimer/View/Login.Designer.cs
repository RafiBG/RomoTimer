namespace RomoTimerForm.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin_login = new MaterialSkin.Controls.MaterialButton();
            this.btnRegisterFirst_Login = new MaterialSkin.Controls.MaterialButton();
            this.txtUsername_login = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtPassword_login = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnHidePassword = new MaterialSkin.Controls.MaterialButton();
            this.btnShowPassword = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnLogin_login
            // 
            this.btnLogin_login.AutoSize = false;
            this.btnLogin_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin_login.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin_login.Depth = 0;
            this.btnLogin_login.HighEmphasis = true;
            this.btnLogin_login.Icon = null;
            this.btnLogin_login.Location = new System.Drawing.Point(109, 284);
            this.btnLogin_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin_login.Name = "btnLogin_login";
            this.btnLogin_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin_login.Size = new System.Drawing.Size(116, 43);
            this.btnLogin_login.TabIndex = 43;
            this.btnLogin_login.Text = "Login";
            this.btnLogin_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin_login.UseAccentColor = false;
            this.btnLogin_login.UseVisualStyleBackColor = false;
            this.btnLogin_login.Click += new System.EventHandler(this.btnLogin_login_Click);
            // 
            // btnRegisterFirst_Login
            // 
            this.btnRegisterFirst_Login.AutoSize = false;
            this.btnRegisterFirst_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterFirst_Login.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegisterFirst_Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegisterFirst_Login.Depth = 0;
            this.btnRegisterFirst_Login.HighEmphasis = true;
            this.btnRegisterFirst_Login.Icon = null;
            this.btnRegisterFirst_Login.Location = new System.Drawing.Point(109, 397);
            this.btnRegisterFirst_Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegisterFirst_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegisterFirst_Login.Name = "btnRegisterFirst_Login";
            this.btnRegisterFirst_Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegisterFirst_Login.Size = new System.Drawing.Size(116, 44);
            this.btnRegisterFirst_Login.TabIndex = 44;
            this.btnRegisterFirst_Login.Text = "Register";
            this.btnRegisterFirst_Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegisterFirst_Login.UseAccentColor = false;
            this.btnRegisterFirst_Login.UseVisualStyleBackColor = false;
            this.btnRegisterFirst_Login.Click += new System.EventHandler(this.btnRegisterFirst_Login_Click);
            // 
            // txtUsername_login
            // 
            this.txtUsername_login.AllowPromptAsInput = true;
            this.txtUsername_login.AnimateReadOnly = false;
            this.txtUsername_login.AsciiOnly = false;
            this.txtUsername_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsername_login.BeepOnError = false;
            this.txtUsername_login.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsername_login.Depth = 0;
            this.txtUsername_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername_login.HidePromptOnLeave = false;
            this.txtUsername_login.HideSelection = true;
            this.txtUsername_login.Hint = "Username";
            this.txtUsername_login.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtUsername_login.LeadingIcon = null;
            this.txtUsername_login.Location = new System.Drawing.Point(42, 120);
            this.txtUsername_login.Mask = "";
            this.txtUsername_login.MaxLength = 32767;
            this.txtUsername_login.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername_login.Name = "txtUsername_login";
            this.txtUsername_login.PasswordChar = '\0';
            this.txtUsername_login.PrefixSuffixText = null;
            this.txtUsername_login.PromptChar = '_';
            this.txtUsername_login.ReadOnly = false;
            this.txtUsername_login.RejectInputOnFirstFailure = false;
            this.txtUsername_login.ResetOnPrompt = true;
            this.txtUsername_login.ResetOnSpace = true;
            this.txtUsername_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername_login.SelectedText = "";
            this.txtUsername_login.SelectionLength = 0;
            this.txtUsername_login.SelectionStart = 0;
            this.txtUsername_login.ShortcutsEnabled = true;
            this.txtUsername_login.Size = new System.Drawing.Size(250, 48);
            this.txtUsername_login.SkipLiterals = true;
            this.txtUsername_login.TabIndex = 45;
            this.txtUsername_login.TabStop = false;
            this.txtUsername_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername_login.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsername_login.TrailingIcon = null;
            this.txtUsername_login.UseSystemPasswordChar = false;
            this.txtUsername_login.ValidatingType = null;
            // 
            // txtPassword_login
            // 
            this.txtPassword_login.AllowPromptAsInput = true;
            this.txtPassword_login.AnimateReadOnly = false;
            this.txtPassword_login.AsciiOnly = false;
            this.txtPassword_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword_login.BeepOnError = false;
            this.txtPassword_login.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword_login.Depth = 0;
            this.txtPassword_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword_login.HidePromptOnLeave = false;
            this.txtPassword_login.HideSelection = true;
            this.txtPassword_login.Hint = "Password";
            this.txtPassword_login.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPassword_login.LeadingIcon = null;
            this.txtPassword_login.Location = new System.Drawing.Point(42, 213);
            this.txtPassword_login.Mask = "";
            this.txtPassword_login.MaxLength = 32767;
            this.txtPassword_login.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword_login.Name = "txtPassword_login";
            this.txtPassword_login.PasswordChar = '*';
            this.txtPassword_login.PrefixSuffixText = null;
            this.txtPassword_login.PromptChar = '_';
            this.txtPassword_login.ReadOnly = false;
            this.txtPassword_login.RejectInputOnFirstFailure = false;
            this.txtPassword_login.ResetOnPrompt = true;
            this.txtPassword_login.ResetOnSpace = true;
            this.txtPassword_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword_login.SelectedText = "";
            this.txtPassword_login.SelectionLength = 0;
            this.txtPassword_login.SelectionStart = 0;
            this.txtPassword_login.ShortcutsEnabled = true;
            this.txtPassword_login.Size = new System.Drawing.Size(250, 48);
            this.txtPassword_login.SkipLiterals = true;
            this.txtPassword_login.TabIndex = 46;
            this.txtPassword_login.TabStop = false;
            this.txtPassword_login.Tag = "";
            this.txtPassword_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword_login.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword_login.TrailingIcon = null;
            this.txtPassword_login.UseSystemPasswordChar = false;
            this.txtPassword_login.ValidatingType = null;
            this.txtPassword_login.Click += new System.EventHandler(this.txtPassword_login_Click);
            this.txtPassword_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_login_KeyDown);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(39, 358);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(277, 19);
            this.materialLabel1.TabIndex = 47;
            this.materialLabel1.Text = "If you don`t have registration, click here";
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.AutoSize = false;
            this.btnHidePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHidePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnHidePassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHidePassword.Depth = 0;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHidePassword.HighEmphasis = true;
            this.btnHidePassword.Icon = ((System.Drawing.Image)(resources.GetObject("btnHidePassword.Icon")));
            this.btnHidePassword.Location = new System.Drawing.Point(253, 213);
            this.btnHidePassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHidePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHidePassword.Size = new System.Drawing.Size(39, 48);
            this.btnHidePassword.TabIndex = 48;
            this.btnHidePassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHidePassword.UseAccentColor = false;
            this.btnHidePassword.UseVisualStyleBackColor = false;
            this.btnHidePassword.Click += new System.EventHandler(this.btnHidePassword_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.AutoSize = false;
            this.btnShowPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowPassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShowPassword.Depth = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowPassword.HighEmphasis = true;
            this.btnShowPassword.Icon = ((System.Drawing.Image)(resources.GetObject("btnShowPassword.Icon")));
            this.btnShowPassword.Location = new System.Drawing.Point(254, 213);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShowPassword.Size = new System.Drawing.Size(38, 48);
            this.btnShowPassword.TabIndex = 49;
            this.btnShowPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowPassword.UseAccentColor = false;
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPassword_login);
            this.Controls.Add(this.txtUsername_login);
            this.Controls.Add(this.btnRegisterFirst_Login);
            this.Controls.Add(this.btnLogin_login);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLogin_login;
        private MaterialSkin.Controls.MaterialButton btnRegisterFirst_Login;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUsername_login;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword_login;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnHidePassword;
        private MaterialSkin.Controls.MaterialButton btnShowPassword;
    }
}