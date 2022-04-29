namespace RomoTimer
{
    partial class RomoTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RomoTimer));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lbldot1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShortBreak = new System.Windows.Forms.Button();
            this.btnLongBreak = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTable = new System.Windows.Forms.Button();
            this.btnDarkModeRomoTimer = new System.Windows.Forms.Button();
            this.MoreToolsRomoTimer = new System.Windows.Forms.Button();
            this.btnRomoTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(240, 296);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(335, 296);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHours.Location = new System.Drawing.Point(251, 143);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(64, 46);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "00";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinutes.Location = new System.Drawing.Point(346, 143);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(64, 46);
            this.lblMinutes.TabIndex = 3;
            this.lblMinutes.Text = "00";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeconds.Location = new System.Drawing.Point(442, 143);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(64, 46);
            this.lblSeconds.TabIndex = 4;
            this.lblSeconds.Text = "00";
            // 
            // lbldot1
            // 
            this.lbldot1.AutoSize = true;
            this.lbldot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldot1.Location = new System.Drawing.Point(316, 139);
            this.lbldot1.Name = "lbldot1";
            this.lbldot1.Size = new System.Drawing.Size(31, 46);
            this.lbldot1.TabIndex = 5;
            this.lbldot1.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(414, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = ".";
            // 
            // btnShortBreak
            // 
            this.btnShortBreak.Location = new System.Drawing.Point(595, 197);
            this.btnShortBreak.Name = "btnShortBreak";
            this.btnShortBreak.Size = new System.Drawing.Size(75, 23);
            this.btnShortBreak.TabIndex = 7;
            this.btnShortBreak.Text = "Short Break";
            this.btnShortBreak.UseVisualStyleBackColor = true;
            // 
            // btnLongBreak
            // 
            this.btnLongBreak.Location = new System.Drawing.Point(595, 235);
            this.btnLongBreak.Name = "btnLongBreak";
            this.btnLongBreak.Size = new System.Drawing.Size(75, 23);
            this.btnLongBreak.TabIndex = 8;
            this.btnLongBreak.Text = "Long Break";
            this.btnLongBreak.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(441, 296);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Random Number Generator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Calculator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SQL Table Form";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(595, 29);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(75, 23);
            this.btnTable.TabIndex = 13;
            this.btnTable.Text = "Table";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnDarkModeRomoTimer
            // 
            this.btnDarkModeRomoTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDarkModeRomoTimer.Location = new System.Drawing.Point(276, 12);
            this.btnDarkModeRomoTimer.Name = "btnDarkModeRomoTimer";
            this.btnDarkModeRomoTimer.Size = new System.Drawing.Size(129, 47);
            this.btnDarkModeRomoTimer.TabIndex = 34;
            this.btnDarkModeRomoTimer.Text = "Dark Mode";
            this.btnDarkModeRomoTimer.UseVisualStyleBackColor = true;
            // 
            // MoreToolsRomoTimer
            // 
            this.MoreToolsRomoTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreToolsRomoTimer.Location = new System.Drawing.Point(422, 12);
            this.MoreToolsRomoTimer.Name = "MoreToolsRomoTimer";
            this.MoreToolsRomoTimer.Size = new System.Drawing.Size(129, 47);
            this.MoreToolsRomoTimer.TabIndex = 35;
            this.MoreToolsRomoTimer.Text = "More Tools";
            this.MoreToolsRomoTimer.UseVisualStyleBackColor = true;
            this.MoreToolsRomoTimer.Click += new System.EventHandler(this.MoreToolsRomoTimer_Click);
            // 
            // btnRomoTimer
            // 
            this.btnRomoTimer.Location = new System.Drawing.Point(342, 113);
            this.btnRomoTimer.Name = "btnRomoTimer";
            this.btnRomoTimer.Size = new System.Drawing.Size(75, 23);
            this.btnRomoTimer.TabIndex = 36;
            this.btnRomoTimer.Text = "RomoTimer";
            this.btnRomoTimer.UseVisualStyleBackColor = true;
            this.btnRomoTimer.Click += new System.EventHandler(this.btnRomoTimer_Click);
            // 
            // RomoTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 386);
            this.Controls.Add(this.btnRomoTimer);
            this.Controls.Add(this.MoreToolsRomoTimer);
            this.Controls.Add(this.btnDarkModeRomoTimer);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLongBreak);
            this.Controls.Add(this.btnShortBreak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldot1);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RomoTimer";
            this.Text = "RomoTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lbldot1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShortBreak;
        private System.Windows.Forms.Button btnLongBreak;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnDarkModeRomoTimer;
        private System.Windows.Forms.Button MoreToolsRomoTimer;
        private System.Windows.Forms.Button btnRomoTimer;
    }
}

