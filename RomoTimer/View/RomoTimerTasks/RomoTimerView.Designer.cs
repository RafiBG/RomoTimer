namespace RomoTimerForm
{
    partial class RomoTimerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RomoTimerView));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRomoTimer = new MaterialSkin.Controls.MaterialButton();
            this.btnStart = new MaterialSkin.Controls.MaterialButton();
            this.btnStop = new MaterialSkin.Controls.MaterialButton();
            this.btnReset = new MaterialSkin.Controls.MaterialButton();
            this.MoreToolsRomoTimer1 = new MaterialSkin.Controls.MaterialButton();
            this.btnTable = new MaterialSkin.Controls.MaterialButton();
            this.btnBreakTime = new MaterialSkin.Controls.MaterialButton();
            this.lblMinutes1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbldot3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSeconds1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMinutes = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblLoggedUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblDisplayName = new MaterialSkin.Controls.MaterialLabel();
            this.txtTask1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtBTMinutes = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblBreakSeconds = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblBreakMinutes = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBreakReset = new MaterialSkin.Controls.MaterialButton();
            this.btnBreakStop = new MaterialSkin.Controls.MaterialButton();
            this.btnBreakStart = new MaterialSkin.Controls.MaterialButton();
            this.Breaktimer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnRomoTimer.Location = new System.Drawing.Point(104, 157);
            this.btnRomoTimer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRomoTimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRomoTimer.Name = "btnRomoTimer";
            this.btnRomoTimer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRomoTimer.Size = new System.Drawing.Size(106, 44);
            this.btnRomoTimer.TabIndex = 42;
            this.btnRomoTimer.Text = "RomoTimer";
            this.btnRomoTimer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRomoTimer.UseAccentColor = false;
            this.btnRomoTimer.UseVisualStyleBackColor = false;
            this.btnRomoTimer.Click += new System.EventHandler(this.btnRomoTimer_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = false;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStart.Depth = 0;
            this.btnStart.HighEmphasis = true;
            this.btnStart.Icon = null;
            this.btnStart.Location = new System.Drawing.Point(25, 336);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStart.Size = new System.Drawing.Size(81, 44);
            this.btnStart.TabIndex = 43;
            this.btnStart.Text = "Start";
            this.btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStart.UseAccentColor = false;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = false;
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStop.Depth = 0;
            this.btnStop.HighEmphasis = true;
            this.btnStop.Icon = null;
            this.btnStop.Location = new System.Drawing.Point(113, 336);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStop.Size = new System.Drawing.Size(81, 44);
            this.btnStop.TabIndex = 44;
            this.btnStop.Text = "Stop";
            this.btnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStop.UseAccentColor = false;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = false;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReset.Depth = 0;
            this.btnReset.HighEmphasis = true;
            this.btnReset.Icon = null;
            this.btnReset.Location = new System.Drawing.Point(202, 336);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReset.Size = new System.Drawing.Size(81, 44);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "Reset";
            this.btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReset.UseAccentColor = false;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // MoreToolsRomoTimer1
            // 
            this.MoreToolsRomoTimer1.AutoSize = false;
            this.MoreToolsRomoTimer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoreToolsRomoTimer1.BackColor = System.Drawing.SystemColors.Control;
            this.MoreToolsRomoTimer1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MoreToolsRomoTimer1.Depth = 0;
            this.MoreToolsRomoTimer1.HighEmphasis = true;
            this.MoreToolsRomoTimer1.Icon = null;
            this.MoreToolsRomoTimer1.Location = new System.Drawing.Point(387, 79);
            this.MoreToolsRomoTimer1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MoreToolsRomoTimer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.MoreToolsRomoTimer1.Name = "MoreToolsRomoTimer1";
            this.MoreToolsRomoTimer1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MoreToolsRomoTimer1.Size = new System.Drawing.Size(102, 44);
            this.MoreToolsRomoTimer1.TabIndex = 46;
            this.MoreToolsRomoTimer1.Text = "Go back";
            this.MoreToolsRomoTimer1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MoreToolsRomoTimer1.UseAccentColor = false;
            this.MoreToolsRomoTimer1.UseVisualStyleBackColor = false;
            this.MoreToolsRomoTimer1.Click += new System.EventHandler(this.MoreToolsRomoTimer_Click);
            // 
            // btnTable
            // 
            this.btnTable.AutoSize = false;
            this.btnTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTable.BackColor = System.Drawing.SystemColors.Control;
            this.btnTable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTable.Depth = 0;
            this.btnTable.HighEmphasis = true;
            this.btnTable.Icon = null;
            this.btnTable.Location = new System.Drawing.Point(507, 79);
            this.btnTable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTable.Name = "btnTable";
            this.btnTable.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTable.Size = new System.Drawing.Size(77, 44);
            this.btnTable.TabIndex = 52;
            this.btnTable.Text = "Table";
            this.btnTable.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTable.UseAccentColor = false;
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnBreakTime
            // 
            this.btnBreakTime.AutoSize = false;
            this.btnBreakTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBreakTime.BackColor = System.Drawing.SystemColors.Control;
            this.btnBreakTime.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBreakTime.Depth = 0;
            this.btnBreakTime.HighEmphasis = true;
            this.btnBreakTime.Icon = null;
            this.btnBreakTime.Location = new System.Drawing.Point(19, 30);
            this.btnBreakTime.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBreakTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBreakTime.Name = "btnBreakTime";
            this.btnBreakTime.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBreakTime.Size = new System.Drawing.Size(104, 44);
            this.btnBreakTime.TabIndex = 53;
            this.btnBreakTime.Text = "Break Time";
            this.btnBreakTime.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBreakTime.UseAccentColor = false;
            this.btnBreakTime.UseVisualStyleBackColor = false;
            this.btnBreakTime.Click += new System.EventHandler(this.btnBreakTime_Click);
            // 
            // lblMinutes1
            // 
            this.lblMinutes1.AutoSize = true;
            this.lblMinutes1.Depth = 0;
            this.lblMinutes1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMinutes1.Location = new System.Drawing.Point(125, 290);
            this.lblMinutes1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMinutes1.Name = "lblMinutes1";
            this.lblMinutes1.Size = new System.Drawing.Size(19, 19);
            this.lblMinutes1.TabIndex = 57;
            this.lblMinutes1.Text = "00";
            // 
            // lbldot3
            // 
            this.lbldot3.AutoSize = true;
            this.lbldot3.Depth = 0;
            this.lbldot3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbldot3.Location = new System.Drawing.Point(150, 290);
            this.lbldot3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbldot3.Name = "lbldot3";
            this.lbldot3.Size = new System.Drawing.Size(5, 19);
            this.lbldot3.TabIndex = 58;
            this.lbldot3.Text = ":";
            // 
            // lblSeconds1
            // 
            this.lblSeconds1.AutoSize = true;
            this.lblSeconds1.Depth = 0;
            this.lblSeconds1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSeconds1.Location = new System.Drawing.Point(161, 290);
            this.lblSeconds1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeconds1.Name = "lblSeconds1";
            this.lblSeconds1.Size = new System.Drawing.Size(19, 19);
            this.lblSeconds1.TabIndex = 59;
            this.lblSeconds1.Text = "00";
            // 
            // txtMinutes
            // 
            this.txtMinutes.AllowPromptAsInput = true;
            this.txtMinutes.AnimateReadOnly = false;
            this.txtMinutes.AsciiOnly = false;
            this.txtMinutes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMinutes.BeepOnError = false;
            this.txtMinutes.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMinutes.Depth = 0;
            this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMinutes.HidePromptOnLeave = false;
            this.txtMinutes.HideSelection = true;
            this.txtMinutes.Hint = "Minutes";
            this.txtMinutes.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMinutes.LeadingIcon = null;
            this.txtMinutes.Location = new System.Drawing.Point(202, 217);
            this.txtMinutes.Mask = "";
            this.txtMinutes.MaxLength = 32767;
            this.txtMinutes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.PasswordChar = '\0';
            this.txtMinutes.PrefixSuffixText = null;
            this.txtMinutes.PromptChar = '_';
            this.txtMinutes.ReadOnly = false;
            this.txtMinutes.RejectInputOnFirstFailure = false;
            this.txtMinutes.ResetOnPrompt = true;
            this.txtMinutes.ResetOnSpace = true;
            this.txtMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMinutes.SelectedText = "";
            this.txtMinutes.SelectionLength = 0;
            this.txtMinutes.SelectionStart = 0;
            this.txtMinutes.ShortcutsEnabled = true;
            this.txtMinutes.Size = new System.Drawing.Size(103, 48);
            this.txtMinutes.SkipLiterals = true;
            this.txtMinutes.TabIndex = 60;
            this.txtMinutes.TabStop = false;
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMinutes.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMinutes.TrailingIcon = null;
            this.txtMinutes.UseSystemPasswordChar = false;
            this.txtMinutes.ValidatingType = null;
            this.txtMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutes_KeyPress);
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Depth = 0;
            this.lblLoggedUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoggedUser.Location = new System.Drawing.Point(16, 93);
            this.lblLoggedUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(79, 19);
            this.lblLoggedUser.TabIndex = 63;
            this.lblLoggedUser.Text = "Logged as:";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Depth = 0;
            this.lblDisplayName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDisplayName.Location = new System.Drawing.Point(101, 93);
            this.lblDisplayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(82, 19);
            this.lblDisplayName.TabIndex = 62;
            this.lblDisplayName.Text = "(username)";
            // 
            // txtTask1
            // 
            this.txtTask1.AllowPromptAsInput = true;
            this.txtTask1.AnimateReadOnly = false;
            this.txtTask1.AsciiOnly = false;
            this.txtTask1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTask1.BeepOnError = false;
            this.txtTask1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTask1.Depth = 0;
            this.txtTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTask1.HidePromptOnLeave = false;
            this.txtTask1.HideSelection = true;
            this.txtTask1.Hint = "Task 1";
            this.txtTask1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTask1.LeadingIcon = null;
            this.txtTask1.Location = new System.Drawing.Point(21, 217);
            this.txtTask1.Mask = "";
            this.txtTask1.MaxLength = 32767;
            this.txtTask1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTask1.Name = "txtTask1";
            this.txtTask1.PasswordChar = '\0';
            this.txtTask1.PrefixSuffixText = null;
            this.txtTask1.PromptChar = '_';
            this.txtTask1.ReadOnly = false;
            this.txtTask1.RejectInputOnFirstFailure = false;
            this.txtTask1.ResetOnPrompt = true;
            this.txtTask1.ResetOnSpace = true;
            this.txtTask1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTask1.SelectedText = "";
            this.txtTask1.SelectionLength = 0;
            this.txtTask1.SelectionStart = 0;
            this.txtTask1.ShortcutsEnabled = true;
            this.txtTask1.Size = new System.Drawing.Size(164, 48);
            this.txtTask1.SkipLiterals = true;
            this.txtTask1.TabIndex = 64;
            this.txtTask1.TabStop = false;
            this.txtTask1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTask1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTask1.TrailingIcon = null;
            this.txtTask1.UseSystemPasswordChar = false;
            this.txtTask1.ValidatingType = null;
            // 
            // txtBTMinutes
            // 
            this.txtBTMinutes.AllowPromptAsInput = true;
            this.txtBTMinutes.AnimateReadOnly = false;
            this.txtBTMinutes.AsciiOnly = false;
            this.txtBTMinutes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBTMinutes.BeepOnError = false;
            this.txtBTMinutes.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBTMinutes.Depth = 0;
            this.txtBTMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBTMinutes.HidePromptOnLeave = false;
            this.txtBTMinutes.HideSelection = true;
            this.txtBTMinutes.Hint = "Minutes";
            this.txtBTMinutes.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtBTMinutes.LeadingIcon = null;
            this.txtBTMinutes.Location = new System.Drawing.Point(20, 83);
            this.txtBTMinutes.Mask = "";
            this.txtBTMinutes.MaxLength = 32767;
            this.txtBTMinutes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBTMinutes.Name = "txtBTMinutes";
            this.txtBTMinutes.PasswordChar = '\0';
            this.txtBTMinutes.PrefixSuffixText = null;
            this.txtBTMinutes.PromptChar = '_';
            this.txtBTMinutes.ReadOnly = false;
            this.txtBTMinutes.RejectInputOnFirstFailure = false;
            this.txtBTMinutes.ResetOnPrompt = true;
            this.txtBTMinutes.ResetOnSpace = true;
            this.txtBTMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBTMinutes.SelectedText = "";
            this.txtBTMinutes.SelectionLength = 0;
            this.txtBTMinutes.SelectionStart = 0;
            this.txtBTMinutes.ShortcutsEnabled = true;
            this.txtBTMinutes.Size = new System.Drawing.Size(103, 48);
            this.txtBTMinutes.SkipLiterals = true;
            this.txtBTMinutes.TabIndex = 65;
            this.txtBTMinutes.TabStop = false;
            this.txtBTMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBTMinutes.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBTMinutes.TrailingIcon = null;
            this.txtBTMinutes.UseSystemPasswordChar = false;
            this.txtBTMinutes.ValidatingType = null;
            this.txtBTMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBTMinutes_KeyPress);
            // 
            // lblBreakSeconds
            // 
            this.lblBreakSeconds.AutoSize = true;
            this.lblBreakSeconds.Depth = 0;
            this.lblBreakSeconds.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBreakSeconds.Location = new System.Drawing.Point(205, 55);
            this.lblBreakSeconds.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBreakSeconds.Name = "lblBreakSeconds";
            this.lblBreakSeconds.Size = new System.Drawing.Size(19, 19);
            this.lblBreakSeconds.TabIndex = 68;
            this.lblBreakSeconds.Text = "00";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(194, 55);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(5, 19);
            this.materialLabel2.TabIndex = 67;
            this.materialLabel2.Text = ":";
            // 
            // lblBreakMinutes
            // 
            this.lblBreakMinutes.AutoSize = true;
            this.lblBreakMinutes.Depth = 0;
            this.lblBreakMinutes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBreakMinutes.Location = new System.Drawing.Point(169, 55);
            this.lblBreakMinutes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBreakMinutes.Name = "lblBreakMinutes";
            this.lblBreakMinutes.Size = new System.Drawing.Size(19, 19);
            this.lblBreakMinutes.TabIndex = 66;
            this.lblBreakMinutes.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBreakReset);
            this.groupBox1.Controls.Add(this.lblBreakSeconds);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtBTMinutes);
            this.groupBox1.Controls.Add(this.lblBreakMinutes);
            this.groupBox1.Controls.Add(this.btnBreakStop);
            this.groupBox1.Controls.Add(this.btnBreakStart);
            this.groupBox1.Controls.Add(this.btnBreakTime);
            this.groupBox1.Location = new System.Drawing.Point(355, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 223);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Break Time";
            // 
            // btnBreakReset
            // 
            this.btnBreakReset.AutoSize = false;
            this.btnBreakReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBreakReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnBreakReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBreakReset.Depth = 0;
            this.btnBreakReset.HighEmphasis = true;
            this.btnBreakReset.Icon = null;
            this.btnBreakReset.Location = new System.Drawing.Point(181, 170);
            this.btnBreakReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBreakReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBreakReset.Name = "btnBreakReset";
            this.btnBreakReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBreakReset.Size = new System.Drawing.Size(81, 44);
            this.btnBreakReset.TabIndex = 72;
            this.btnBreakReset.Text = "Reset";
            this.btnBreakReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBreakReset.UseAccentColor = false;
            this.btnBreakReset.UseVisualStyleBackColor = false;
            this.btnBreakReset.Click += new System.EventHandler(this.btnBreakReset_Click);
            // 
            // btnBreakStop
            // 
            this.btnBreakStop.AutoSize = false;
            this.btnBreakStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBreakStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnBreakStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBreakStop.Depth = 0;
            this.btnBreakStop.HighEmphasis = true;
            this.btnBreakStop.Icon = null;
            this.btnBreakStop.Location = new System.Drawing.Point(92, 170);
            this.btnBreakStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBreakStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBreakStop.Name = "btnBreakStop";
            this.btnBreakStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBreakStop.Size = new System.Drawing.Size(81, 44);
            this.btnBreakStop.TabIndex = 71;
            this.btnBreakStop.Text = "Stop";
            this.btnBreakStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBreakStop.UseAccentColor = false;
            this.btnBreakStop.UseVisualStyleBackColor = false;
            this.btnBreakStop.Click += new System.EventHandler(this.btnBreakStop_Click);
            // 
            // btnBreakStart
            // 
            this.btnBreakStart.AutoSize = false;
            this.btnBreakStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBreakStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnBreakStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBreakStart.Depth = 0;
            this.btnBreakStart.HighEmphasis = true;
            this.btnBreakStart.Icon = null;
            this.btnBreakStart.Location = new System.Drawing.Point(7, 170);
            this.btnBreakStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBreakStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBreakStart.Name = "btnBreakStart";
            this.btnBreakStart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBreakStart.Size = new System.Drawing.Size(81, 44);
            this.btnBreakStart.TabIndex = 70;
            this.btnBreakStart.Text = "Start";
            this.btnBreakStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBreakStart.UseAccentColor = false;
            this.btnBreakStart.UseVisualStyleBackColor = false;
            this.btnBreakStart.Click += new System.EventHandler(this.btnBreakStart_Click);
            // 
            // Breaktimer2
            // 
            this.Breaktimer2.Tick += new System.EventHandler(this.Breaktimer2_Tick);
            // 
            // RomoTimerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTask1);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.lblSeconds1);
            this.Controls.Add(this.lbldot3);
            this.Controls.Add(this.lblMinutes1);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.MoreToolsRomoTimer1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRomoTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RomoTimerView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RomoTimer 1 Task";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RomoTimerForm_FormClosed);
            this.Load += new System.EventHandler(this.RomoTimer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialButton btnRomoTimer;
        private MaterialSkin.Controls.MaterialButton btnStart;
        private MaterialSkin.Controls.MaterialButton btnStop;
        private MaterialSkin.Controls.MaterialButton btnReset;
        private MaterialSkin.Controls.MaterialButton MoreToolsRomoTimer1;
        private MaterialSkin.Controls.MaterialButton btnTable;
        private MaterialSkin.Controls.MaterialButton btnBreakTime;
        private MaterialSkin.Controls.MaterialLabel lblMinutes1;
        private MaterialSkin.Controls.MaterialLabel lbldot3;
        private MaterialSkin.Controls.MaterialLabel lblSeconds1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMinutes;
        private MaterialSkin.Controls.MaterialLabel lblLoggedUser;
        private MaterialSkin.Controls.MaterialLabel lblDisplayName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTask1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBTMinutes;
        private MaterialSkin.Controls.MaterialLabel lblBreakSeconds;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblBreakMinutes;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnBreakReset;
        private MaterialSkin.Controls.MaterialButton btnBreakStop;
        private MaterialSkin.Controls.MaterialButton btnBreakStart;
        private System.Windows.Forms.Timer Breaktimer2;
    }
}

