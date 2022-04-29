namespace RomoTimerForm.View
{
    partial class RandomNumberGenerator
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
            this.lblGenerateNumber = new System.Windows.Forms.Label();
            this.MoreToolsRNG = new MaterialSkin.Controls.MaterialButton();
            this.txtMin = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtMax = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblMin = new MaterialSkin.Controls.MaterialLabel();
            this.lblMax = new MaterialSkin.Controls.MaterialLabel();
            this.lblDisplayName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblGenerate = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumber = new MaterialSkin.Controls.MaterialLabel();
            this.btnGenerate = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblGenerateNumber
            // 
            this.lblGenerateNumber.AutoSize = true;
            this.lblGenerateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGenerateNumber.Location = new System.Drawing.Point(107, 322);
            this.lblGenerateNumber.Name = "lblGenerateNumber";
            this.lblGenerateNumber.Size = new System.Drawing.Size(0, 25);
            this.lblGenerateNumber.TabIndex = 12;
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
            this.MoreToolsRNG.Location = new System.Drawing.Point(237, 81);
            this.MoreToolsRNG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MoreToolsRNG.MouseState = MaterialSkin.MouseState.HOVER;
            this.MoreToolsRNG.Name = "MoreToolsRNG";
            this.MoreToolsRNG.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MoreToolsRNG.Size = new System.Drawing.Size(116, 44);
            this.MoreToolsRNG.TabIndex = 40;
            this.MoreToolsRNG.Text = "More Tools";
            this.MoreToolsRNG.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MoreToolsRNG.UseAccentColor = false;
            this.MoreToolsRNG.UseVisualStyleBackColor = false;
            this.MoreToolsRNG.Click += new System.EventHandler(this.MoreToolsRNG_Click);
            // 
            // txtMin
            // 
            this.txtMin.AllowPromptAsInput = true;
            this.txtMin.AnimateReadOnly = false;
            this.txtMin.AsciiOnly = false;
            this.txtMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMin.BeepOnError = false;
            this.txtMin.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMin.Depth = 0;
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMin.HidePromptOnLeave = false;
            this.txtMin.HideSelection = true;
            this.txtMin.Hint = "Minimum number";
            this.txtMin.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMin.LeadingIcon = null;
            this.txtMin.Location = new System.Drawing.Point(59, 196);
            this.txtMin.Mask = "";
            this.txtMin.MaxLength = 32767;
            this.txtMin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMin.Name = "txtMin";
            this.txtMin.PasswordChar = '\0';
            this.txtMin.PrefixSuffixText = null;
            this.txtMin.PromptChar = '_';
            this.txtMin.ReadOnly = false;
            this.txtMin.RejectInputOnFirstFailure = false;
            this.txtMin.ResetOnPrompt = true;
            this.txtMin.ResetOnSpace = true;
            this.txtMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMin.SelectedText = "";
            this.txtMin.SelectionLength = 0;
            this.txtMin.SelectionStart = 0;
            this.txtMin.ShortcutsEnabled = true;
            this.txtMin.Size = new System.Drawing.Size(250, 48);
            this.txtMin.SkipLiterals = true;
            this.txtMin.TabIndex = 44;
            this.txtMin.TabStop = false;
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMin.TrailingIcon = null;
            this.txtMin.UseSystemPasswordChar = false;
            this.txtMin.ValidatingType = null;
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMin_KeyPress);
            // 
            // txtMax
            // 
            this.txtMax.AllowPromptAsInput = true;
            this.txtMax.AnimateReadOnly = false;
            this.txtMax.AsciiOnly = false;
            this.txtMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMax.BeepOnError = false;
            this.txtMax.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMax.Depth = 0;
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMax.HidePromptOnLeave = false;
            this.txtMax.HideSelection = true;
            this.txtMax.Hint = "Maximum number";
            this.txtMax.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMax.LeadingIcon = null;
            this.txtMax.Location = new System.Drawing.Point(59, 309);
            this.txtMax.Mask = "";
            this.txtMax.MaxLength = 32767;
            this.txtMax.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMax.Name = "txtMax";
            this.txtMax.PasswordChar = '\0';
            this.txtMax.PrefixSuffixText = null;
            this.txtMax.PromptChar = '_';
            this.txtMax.ReadOnly = false;
            this.txtMax.RejectInputOnFirstFailure = false;
            this.txtMax.ResetOnPrompt = true;
            this.txtMax.ResetOnSpace = true;
            this.txtMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMax.SelectedText = "";
            this.txtMax.SelectionLength = 0;
            this.txtMax.SelectionStart = 0;
            this.txtMax.ShortcutsEnabled = true;
            this.txtMax.Size = new System.Drawing.Size(250, 48);
            this.txtMax.SkipLiterals = true;
            this.txtMax.TabIndex = 45;
            this.txtMax.TabStop = false;
            this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMax.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMax.TrailingIcon = null;
            this.txtMax.UseSystemPasswordChar = false;
            this.txtMax.ValidatingType = null;
            this.txtMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMax_KeyPress);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Depth = 0;
            this.lblMin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMin.Location = new System.Drawing.Point(162, 161);
            this.lblMin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(28, 19);
            this.lblMin.TabIndex = 47;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Depth = 0;
            this.lblMax.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMax.Location = new System.Drawing.Point(162, 276);
            this.lblMax.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(32, 19);
            this.lblMax.TabIndex = 48;
            this.lblMax.Text = "Max";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Depth = 0;
            this.lblDisplayName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDisplayName.Location = new System.Drawing.Point(103, 95);
            this.lblDisplayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(82, 19);
            this.lblDisplayName.TabIndex = 50;
            this.lblDisplayName.Text = "(username)";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 95);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 51;
            this.materialLabel2.Text = "Logged as:";
            // 
            // lblGenerate
            // 
            this.lblGenerate.AutoSize = true;
            this.lblGenerate.Depth = 0;
            this.lblGenerate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGenerate.Location = new System.Drawing.Point(84, 466);
            this.lblGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGenerate.Name = "lblGenerate";
            this.lblGenerate.Size = new System.Drawing.Size(135, 19);
            this.lblGenerate.TabIndex = 52;
            this.lblGenerate.Text = "Generated number:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Depth = 0;
            this.lblNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumber.Location = new System.Drawing.Point(225, 466);
            this.lblNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(51, 19);
            this.lblNumber.TabIndex = 53;
            this.lblNumber.Text = "(result)";
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = false;
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerate.Depth = 0;
            this.btnGenerate.HighEmphasis = true;
            this.btnGenerate.Icon = null;
            this.btnGenerate.Location = new System.Drawing.Point(123, 388);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerate.Size = new System.Drawing.Size(116, 44);
            this.btnGenerate.TabIndex = 54;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerate.UseAccentColor = false;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // RandomNumberGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 505);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblGenerate);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.MoreToolsRNG);
            this.Controls.Add(this.lblGenerateNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RandomNumberGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Number Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RandomNumberGenerator_FormClosed);
            this.Load += new System.EventHandler(this.RandomNumberGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGenerateNumber;
        private MaterialSkin.Controls.MaterialButton MoreToolsRNG;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMin;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMax;
        private MaterialSkin.Controls.MaterialLabel lblMin;
        private MaterialSkin.Controls.MaterialLabel lblMax;
        private MaterialSkin.Controls.MaterialLabel lblDisplayName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblGenerate;
        private MaterialSkin.Controls.MaterialLabel lblNumber;
        private MaterialSkin.Controls.MaterialButton btnGenerate;
    }
}