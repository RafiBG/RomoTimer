namespace RomoTimerForm
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.lblCalculation = new System.Windows.Forms.Label();
            this.btn7 = new MaterialSkin.Controls.MaterialButton();
            this.btn4 = new MaterialSkin.Controls.MaterialButton();
            this.btn1 = new MaterialSkin.Controls.MaterialButton();
            this.btn8 = new MaterialSkin.Controls.MaterialButton();
            this.btn9 = new MaterialSkin.Controls.MaterialButton();
            this.btn5 = new MaterialSkin.Controls.MaterialButton();
            this.btn2 = new MaterialSkin.Controls.MaterialButton();
            this.btn6 = new MaterialSkin.Controls.MaterialButton();
            this.btn3 = new MaterialSkin.Controls.MaterialButton();
            this.btnDiv = new MaterialSkin.Controls.MaterialButton();
            this.btnMul = new MaterialSkin.Controls.MaterialButton();
            this.btnSub = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnDot = new MaterialSkin.Controls.MaterialButton();
            this.btn0 = new MaterialSkin.Controls.MaterialButton();
            this.btnEqual = new MaterialSkin.Controls.MaterialButton();
            this.btnCE = new MaterialSkin.Controls.MaterialButton();
            this.btnC = new MaterialSkin.Controls.MaterialButton();
            this.txtBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblLoggedUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblDisplayName = new MaterialSkin.Controls.MaterialLabel();
            this.btnMoreToolsCalculator = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalculation.Location = new System.Drawing.Point(40, 141);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(16, 24);
            this.lblCalculation.TabIndex = 34;
            this.lblCalculation.Text = ".";
            // 
            // btn7
            // 
            this.btn7.AutoSize = false;
            this.btn7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn7.BackColor = System.Drawing.SystemColors.Control;
            this.btn7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn7.Depth = 0;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.HighEmphasis = true;
            this.btn7.Icon = null;
            this.btn7.Location = new System.Drawing.Point(34, 246);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn7.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn7.Name = "btn7";
            this.btn7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn7.Size = new System.Drawing.Size(49, 47);
            this.btn7.TabIndex = 53;
            this.btn7.Text = "7";
            this.btn7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn7.UseAccentColor = false;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn4
            // 
            this.btn4.AutoSize = false;
            this.btn4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn4.BackColor = System.Drawing.SystemColors.Control;
            this.btn4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn4.Depth = 0;
            this.btn4.HighEmphasis = true;
            this.btn4.Icon = null;
            this.btn4.Location = new System.Drawing.Point(34, 298);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn4.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn4.Name = "btn4";
            this.btn4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn4.Size = new System.Drawing.Size(49, 47);
            this.btn4.TabIndex = 54;
            this.btn4.Text = "4";
            this.btn4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn4.UseAccentColor = false;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn1
            // 
            this.btn1.AutoSize = false;
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn1.Depth = 0;
            this.btn1.HighEmphasis = true;
            this.btn1.Icon = null;
            this.btn1.Location = new System.Drawing.Point(34, 348);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn1.Name = "btn1";
            this.btn1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn1.Size = new System.Drawing.Size(49, 47);
            this.btn1.TabIndex = 55;
            this.btn1.Text = "1";
            this.btn1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn1.UseAccentColor = false;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn8
            // 
            this.btn8.AutoSize = false;
            this.btn8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn8.BackColor = System.Drawing.SystemColors.Control;
            this.btn8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn8.Depth = 0;
            this.btn8.HighEmphasis = true;
            this.btn8.Icon = null;
            this.btn8.Location = new System.Drawing.Point(89, 247);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn8.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn8.Name = "btn8";
            this.btn8.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn8.Size = new System.Drawing.Size(49, 47);
            this.btn8.TabIndex = 56;
            this.btn8.Text = "8";
            this.btn8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn8.UseAccentColor = false;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn9
            // 
            this.btn9.AutoSize = false;
            this.btn9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn9.BackColor = System.Drawing.SystemColors.Control;
            this.btn9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn9.Depth = 0;
            this.btn9.HighEmphasis = true;
            this.btn9.Icon = null;
            this.btn9.Location = new System.Drawing.Point(146, 247);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn9.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn9.Name = "btn9";
            this.btn9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn9.Size = new System.Drawing.Size(49, 47);
            this.btn9.TabIndex = 57;
            this.btn9.Text = "9";
            this.btn9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn9.UseAccentColor = false;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn5
            // 
            this.btn5.AutoSize = false;
            this.btn5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn5.BackColor = System.Drawing.SystemColors.Control;
            this.btn5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn5.Depth = 0;
            this.btn5.HighEmphasis = true;
            this.btn5.Icon = null;
            this.btn5.Location = new System.Drawing.Point(89, 298);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn5.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn5.Name = "btn5";
            this.btn5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn5.Size = new System.Drawing.Size(49, 47);
            this.btn5.TabIndex = 58;
            this.btn5.Text = "5";
            this.btn5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn5.UseAccentColor = false;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn2
            // 
            this.btn2.AutoSize = false;
            this.btn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn2.Depth = 0;
            this.btn2.HighEmphasis = true;
            this.btn2.Icon = null;
            this.btn2.Location = new System.Drawing.Point(89, 349);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn2.Name = "btn2";
            this.btn2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn2.Size = new System.Drawing.Size(49, 47);
            this.btn2.TabIndex = 59;
            this.btn2.Text = "2";
            this.btn2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn2.UseAccentColor = false;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn6
            // 
            this.btn6.AutoSize = false;
            this.btn6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn6.BackColor = System.Drawing.SystemColors.Control;
            this.btn6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn6.Depth = 0;
            this.btn6.HighEmphasis = true;
            this.btn6.Icon = null;
            this.btn6.Location = new System.Drawing.Point(146, 298);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn6.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn6.Name = "btn6";
            this.btn6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn6.Size = new System.Drawing.Size(49, 47);
            this.btn6.TabIndex = 60;
            this.btn6.Text = "6";
            this.btn6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn6.UseAccentColor = false;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn3
            // 
            this.btn3.AutoSize = false;
            this.btn3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn3.Depth = 0;
            this.btn3.HighEmphasis = true;
            this.btn3.Icon = null;
            this.btn3.Location = new System.Drawing.Point(146, 349);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn3.Name = "btn3";
            this.btn3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn3.Size = new System.Drawing.Size(49, 47);
            this.btn3.TabIndex = 61;
            this.btn3.Text = "3";
            this.btn3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn3.UseAccentColor = false;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumEvent);
            // 
            // btnDiv
            // 
            this.btnDiv.AutoSize = false;
            this.btnDiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDiv.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDiv.Depth = 0;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiv.HighEmphasis = true;
            this.btnDiv.Icon = null;
            this.btnDiv.Location = new System.Drawing.Point(203, 247);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDiv.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDiv.Size = new System.Drawing.Size(49, 47);
            this.btnDiv.TabIndex = 62;
            this.btnDiv.Text = "/";
            this.btnDiv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDiv.UseAccentColor = false;
            this.btnDiv.UseVisualStyleBackColor = false;
            // 
            // btnMul
            // 
            this.btnMul.AutoSize = false;
            this.btnMul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMul.BackColor = System.Drawing.SystemColors.Control;
            this.btnMul.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMul.Depth = 0;
            this.btnMul.HighEmphasis = true;
            this.btnMul.Icon = null;
            this.btnMul.Location = new System.Drawing.Point(203, 298);
            this.btnMul.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMul.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMul.Name = "btnMul";
            this.btnMul.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMul.Size = new System.Drawing.Size(49, 47);
            this.btnMul.TabIndex = 63;
            this.btnMul.Text = "*";
            this.btnMul.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMul.UseAccentColor = false;
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.OperandEvent);
            // 
            // btnSub
            // 
            this.btnSub.AutoSize = false;
            this.btnSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSub.BackColor = System.Drawing.SystemColors.Control;
            this.btnSub.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSub.Depth = 0;
            this.btnSub.HighEmphasis = true;
            this.btnSub.Icon = null;
            this.btnSub.Location = new System.Drawing.Point(203, 349);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSub.Name = "btnSub";
            this.btnSub.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSub.Size = new System.Drawing.Size(49, 47);
            this.btnSub.TabIndex = 64;
            this.btnSub.Text = "-";
            this.btnSub.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSub.UseAccentColor = false;
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.OperandEvent);
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
            this.btnAdd.Location = new System.Drawing.Point(203, 402);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(49, 47);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "+";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.OperandEvent);
            // 
            // btnDot
            // 
            this.btnDot.AutoSize = false;
            this.btnDot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDot.BackColor = System.Drawing.SystemColors.Control;
            this.btnDot.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDot.Depth = 0;
            this.btnDot.HighEmphasis = true;
            this.btnDot.Icon = null;
            this.btnDot.Location = new System.Drawing.Point(146, 402);
            this.btnDot.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDot.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDot.Name = "btnDot";
            this.btnDot.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDot.Size = new System.Drawing.Size(49, 47);
            this.btnDot.TabIndex = 66;
            this.btnDot.Text = ".";
            this.btnDot.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDot.UseAccentColor = false;
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.AutoSize = false;
            this.btn0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn0.BackColor = System.Drawing.SystemColors.Control;
            this.btn0.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn0.Depth = 0;
            this.btn0.HighEmphasis = true;
            this.btn0.Icon = null;
            this.btn0.Location = new System.Drawing.Point(34, 402);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn0.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn0.Name = "btn0";
            this.btn0.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn0.Size = new System.Drawing.Size(104, 47);
            this.btn0.TabIndex = 67;
            this.btn0.Text = "0";
            this.btn0.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn0.UseAccentColor = false;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumEvent);
            // 
            // btnEqual
            // 
            this.btnEqual.AutoSize = false;
            this.btnEqual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEqual.BackColor = System.Drawing.SystemColors.Control;
            this.btnEqual.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEqual.Depth = 0;
            this.btnEqual.HighEmphasis = true;
            this.btnEqual.Icon = null;
            this.btnEqual.Location = new System.Drawing.Point(258, 349);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEqual.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEqual.Size = new System.Drawing.Size(55, 100);
            this.btnEqual.TabIndex = 68;
            this.btnEqual.Text = "=";
            this.btnEqual.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEqual.UseAccentColor = false;
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnCE
            // 
            this.btnCE.AutoSize = false;
            this.btnCE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCE.BackColor = System.Drawing.SystemColors.Control;
            this.btnCE.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCE.Depth = 0;
            this.btnCE.HighEmphasis = true;
            this.btnCE.Icon = null;
            this.btnCE.Location = new System.Drawing.Point(258, 247);
            this.btnCE.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCE.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCE.Name = "btnCE";
            this.btnCE.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCE.Size = new System.Drawing.Size(55, 47);
            this.btnCE.TabIndex = 69;
            this.btnCE.Text = "CE";
            this.btnCE.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCE.UseAccentColor = false;
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.AutoSize = false;
            this.btnC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnC.BackColor = System.Drawing.SystemColors.Control;
            this.btnC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnC.Depth = 0;
            this.btnC.HighEmphasis = true;
            this.btnC.Icon = null;
            this.btnC.Location = new System.Drawing.Point(258, 298);
            this.btnC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnC.Name = "btnC";
            this.btnC.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnC.Size = new System.Drawing.Size(55, 47);
            this.btnC.TabIndex = 70;
            this.btnC.Text = "C";
            this.btnC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnC.UseAccentColor = false;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // txtBox
            // 
            this.txtBox.AllowPromptAsInput = true;
            this.txtBox.AnimateReadOnly = false;
            this.txtBox.AsciiOnly = false;
            this.txtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBox.BeepOnError = false;
            this.txtBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtBox.Depth = 0;
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBox.HidePromptOnLeave = false;
            this.txtBox.HideSelection = true;
            this.txtBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtBox.LeadingIcon = null;
            this.txtBox.Location = new System.Drawing.Point(34, 168);
            this.txtBox.Mask = "";
            this.txtBox.MaxLength = 32767;
            this.txtBox.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBox.Name = "txtBox";
            this.txtBox.PasswordChar = '\0';
            this.txtBox.PrefixSuffixText = null;
            this.txtBox.PromptChar = '_';
            this.txtBox.ReadOnly = true;
            this.txtBox.RejectInputOnFirstFailure = false;
            this.txtBox.ResetOnPrompt = true;
            this.txtBox.ResetOnSpace = true;
            this.txtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBox.SelectedText = "";
            this.txtBox.SelectionLength = 0;
            this.txtBox.SelectionStart = 0;
            this.txtBox.ShortcutsEnabled = true;
            this.txtBox.Size = new System.Drawing.Size(279, 48);
            this.txtBox.SkipLiterals = true;
            this.txtBox.TabIndex = 71;
            this.txtBox.TabStop = false;
            this.txtBox.Text = "0";
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBox.TrailingIcon = null;
            this.txtBox.UseSystemPasswordChar = false;
            this.txtBox.ValidatingType = null;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Depth = 0;
            this.lblLoggedUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoggedUser.Location = new System.Drawing.Point(31, 90);
            this.lblLoggedUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(79, 19);
            this.lblLoggedUser.TabIndex = 76;
            this.lblLoggedUser.Text = "Logged as:";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Depth = 0;
            this.lblDisplayName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDisplayName.Location = new System.Drawing.Point(116, 90);
            this.lblDisplayName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(82, 19);
            this.lblDisplayName.TabIndex = 75;
            this.lblDisplayName.Text = "(username)";
            // 
            // btnMoreToolsCalculator
            // 
            this.btnMoreToolsCalculator.AutoSize = false;
            this.btnMoreToolsCalculator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMoreToolsCalculator.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoreToolsCalculator.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMoreToolsCalculator.Depth = 0;
            this.btnMoreToolsCalculator.HighEmphasis = true;
            this.btnMoreToolsCalculator.Icon = null;
            this.btnMoreToolsCalculator.Location = new System.Drawing.Point(232, 79);
            this.btnMoreToolsCalculator.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMoreToolsCalculator.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMoreToolsCalculator.Name = "btnMoreToolsCalculator";
            this.btnMoreToolsCalculator.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMoreToolsCalculator.Size = new System.Drawing.Size(102, 48);
            this.btnMoreToolsCalculator.TabIndex = 77;
            this.btnMoreToolsCalculator.Text = "More Tools";
            this.btnMoreToolsCalculator.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMoreToolsCalculator.UseAccentColor = false;
            this.btnMoreToolsCalculator.UseVisualStyleBackColor = false;
            this.btnMoreToolsCalculator.Click += new System.EventHandler(this.btnMoreToolsCalculator_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 458);
            this.Controls.Add(this.btnMoreToolsCalculator);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.lblCalculation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calculator_FormClosed);
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCalculation;
        private MaterialSkin.Controls.MaterialButton btn7;
        private MaterialSkin.Controls.MaterialButton btn4;
        private MaterialSkin.Controls.MaterialButton btn1;
        private MaterialSkin.Controls.MaterialButton btn8;
        private MaterialSkin.Controls.MaterialButton btn9;
        private MaterialSkin.Controls.MaterialButton btn5;
        private MaterialSkin.Controls.MaterialButton btn2;
        private MaterialSkin.Controls.MaterialButton btn6;
        private MaterialSkin.Controls.MaterialButton btn3;
        private MaterialSkin.Controls.MaterialButton btnDiv;
        private MaterialSkin.Controls.MaterialButton btnMul;
        private MaterialSkin.Controls.MaterialButton btnSub;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnDot;
        private MaterialSkin.Controls.MaterialButton btn0;
        private MaterialSkin.Controls.MaterialButton btnEqual;
        private MaterialSkin.Controls.MaterialButton btnCE;
        private MaterialSkin.Controls.MaterialButton btnC;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBox;
        private MaterialSkin.Controls.MaterialLabel lblLoggedUser;
        private MaterialSkin.Controls.MaterialLabel lblDisplayName;
        private MaterialSkin.Controls.MaterialButton btnMoreToolsCalculator;
    }
}