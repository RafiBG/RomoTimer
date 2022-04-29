namespace RomoTimer.View
{
    partial class CurrencyConverter
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
            this.lblTextCA = new MaterialSkin.Controls.MaterialLabel();
            this.cbSecondCurrency = new MaterialSkin.Controls.MaterialComboBox();
            this.cbFirstCurrency = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.lblResult = new MaterialSkin.Controls.MaterialLabel();
            this.btnConvert = new MaterialSkin.Controls.MaterialButton();
            this.btnMoreTools = new MaterialSkin.Controls.MaterialButton();
            this.lblLoggedUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblDisplayName = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblTextCA
            // 
            this.lblTextCA.AutoSize = true;
            this.lblTextCA.Depth = 0;
            this.lblTextCA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTextCA.Location = new System.Drawing.Point(48, 451);
            this.lblTextCA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTextCA.Name = "lblTextCA";
            this.lblTextCA.Size = new System.Drawing.Size(140, 19);
            this.lblTextCA.TabIndex = 0;
            this.lblTextCA.Text = "Converted Amount :";
            // 
            // cbSecondCurrency
            // 
            this.cbSecondCurrency.AutoResize = false;
            this.cbSecondCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSecondCurrency.Depth = 0;
            this.cbSecondCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSecondCurrency.DropDownHeight = 174;
            this.cbSecondCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecondCurrency.DropDownWidth = 121;
            this.cbSecondCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSecondCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSecondCurrency.FormattingEnabled = true;
            this.cbSecondCurrency.IntegralHeight = false;
            this.cbSecondCurrency.ItemHeight = 43;
            this.cbSecondCurrency.Items.AddRange(new object[] {
            "BGN",
            "EUR",
            "USD",
            "CAD"});
            this.cbSecondCurrency.Location = new System.Drawing.Point(90, 299);
            this.cbSecondCurrency.MaxDropDownItems = 4;
            this.cbSecondCurrency.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSecondCurrency.Name = "cbSecondCurrency";
            this.cbSecondCurrency.Size = new System.Drawing.Size(121, 49);
            this.cbSecondCurrency.StartIndex = 0;
            this.cbSecondCurrency.TabIndex = 1;
            // 
            // cbFirstCurrency
            // 
            this.cbFirstCurrency.AutoResize = false;
            this.cbFirstCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFirstCurrency.Depth = 0;
            this.cbFirstCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFirstCurrency.DropDownHeight = 174;
            this.cbFirstCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirstCurrency.DropDownWidth = 121;
            this.cbFirstCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFirstCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFirstCurrency.FormattingEnabled = true;
            this.cbFirstCurrency.IntegralHeight = false;
            this.cbFirstCurrency.ItemHeight = 43;
            this.cbFirstCurrency.Items.AddRange(new object[] {
            "EUR",
            "BGN",
            "USD",
            "CAD"});
            this.cbFirstCurrency.Location = new System.Drawing.Point(90, 213);
            this.cbFirstCurrency.MaxDropDownItems = 4;
            this.cbFirstCurrency.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFirstCurrency.Name = "cbFirstCurrency";
            this.cbFirstCurrency.Size = new System.Drawing.Size(121, 49);
            this.cbFirstCurrency.StartIndex = 0;
            this.cbFirstCurrency.TabIndex = 2;
            // 
            // txtNumber
            // 
            this.txtNumber.AnimateReadOnly = false;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.Depth = 0;
            this.txtNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumber.LeadingIcon = null;
            this.txtNumber.Location = new System.Drawing.Point(51, 141);
            this.txtNumber.MaxLength = 50;
            this.txtNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumber.Multiline = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(204, 50);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.Text = "";
            this.txtNumber.TrailingIcon = null;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Depth = 0;
            this.lblResult.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblResult.Location = new System.Drawing.Point(194, 451);
            this.lblResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(51, 19);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "(result)";
            // 
            // btnConvert
            // 
            this.btnConvert.AutoSize = false;
            this.btnConvert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConvert.BackColor = System.Drawing.SystemColors.Control;
            this.btnConvert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConvert.Depth = 0;
            this.btnConvert.HighEmphasis = true;
            this.btnConvert.Icon = null;
            this.btnConvert.Location = new System.Drawing.Point(65, 377);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConvert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConvert.Size = new System.Drawing.Size(168, 44);
            this.btnConvert.TabIndex = 55;
            this.btnConvert.Text = "Convert";
            this.btnConvert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConvert.UseAccentColor = false;
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnMoreTools
            // 
            this.btnMoreTools.AutoSize = false;
            this.btnMoreTools.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMoreTools.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoreTools.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMoreTools.Depth = 0;
            this.btnMoreTools.HighEmphasis = true;
            this.btnMoreTools.Icon = null;
            this.btnMoreTools.Location = new System.Drawing.Point(235, 70);
            this.btnMoreTools.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMoreTools.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMoreTools.Name = "btnMoreTools";
            this.btnMoreTools.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMoreTools.Size = new System.Drawing.Size(80, 50);
            this.btnMoreTools.TabIndex = 56;
            this.btnMoreTools.Text = "Go back";
            this.btnMoreTools.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMoreTools.UseAccentColor = false;
            this.btnMoreTools.UseVisualStyleBackColor = false;
            this.btnMoreTools.Click += new System.EventHandler(this.btnMoreTools_Click);
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Depth = 0;
            this.lblLoggedUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoggedUser.Location = new System.Drawing.Point(23, 87);
            this.lblLoggedUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(79, 19);
            this.lblLoggedUser.TabIndex = 58;
            this.lblLoggedUser.Text = "Logged as:";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Depth = 0;
            this.lblDisplayName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDisplayName.Location = new System.Drawing.Point(108, 87);
            this.lblDisplayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(82, 19);
            this.lblDisplayName.TabIndex = 57;
            this.lblDisplayName.Text = "(username)";
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 505);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.btnMoreTools);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.cbFirstCurrency);
            this.Controls.Add(this.cbSecondCurrency);
            this.Controls.Add(this.lblTextCA);
            this.MaximizeBox = false;
            this.Name = "CurrencyConverter";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurrencyConverter_FormClosing);
            this.Load += new System.EventHandler(this.CurrencyConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTextCA;
        private MaterialSkin.Controls.MaterialComboBox cbSecondCurrency;
        private MaterialSkin.Controls.MaterialComboBox cbFirstCurrency;
        private MaterialSkin.Controls.MaterialTextBox txtNumber;
        private MaterialSkin.Controls.MaterialLabel lblResult;
        private MaterialSkin.Controls.MaterialButton btnConvert;
        private MaterialSkin.Controls.MaterialButton btnMoreTools;
        private MaterialSkin.Controls.MaterialLabel lblLoggedUser;
        private MaterialSkin.Controls.MaterialLabel lblDisplayName;
    }
}