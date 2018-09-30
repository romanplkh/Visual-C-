namespace Clock
{
    partial class ClockForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnHour = new System.Windows.Forms.Button();
            this.btnMinute = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.grpAM_PM = new System.Windows.Forms.GroupBox();
            this.rdoPM = new System.Windows.Forms.RadioButton();
            this.rdoAM = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCurText = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.grpAM_PM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(7, 301);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(336, 25);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(7, 279);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(336, 25);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(7, 257);
            this.btnSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(336, 24);
            this.btnSet.TabIndex = 12;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnHour
            // 
            this.btnHour.Location = new System.Drawing.Point(7, 10);
            this.btnHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHour.Name = "btnHour";
            this.btnHour.Size = new System.Drawing.Size(70, 23);
            this.btnHour.TabIndex = 0;
            this.btnHour.Text = "HOUR";
            this.btnHour.UseVisualStyleBackColor = true;
            this.btnHour.Click += new System.EventHandler(this.btnHour_Click);
            // 
            // btnMinute
            // 
            this.btnMinute.Location = new System.Drawing.Point(74, 10);
            this.btnMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinute.Name = "btnMinute";
            this.btnMinute.Size = new System.Drawing.Size(70, 23);
            this.btnMinute.TabIndex = 1;
            this.btnMinute.Text = "MINUTE";
            this.btnMinute.UseVisualStyleBackColor = true;
            this.btnMinute.Click += new System.EventHandler(this.btnMinute_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(141, 10);
            this.btnSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(70, 23);
            this.btnSecond.TabIndex = 2;
            this.btnSecond.Text = "SECOND";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(208, 10);
            this.btnOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(70, 23);
            this.btnOn.TabIndex = 3;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(273, 10);
            this.btnOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(70, 23);
            this.btnOff.TabIndex = 4;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(9, 58);
            this.txtHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(48, 20);
            this.txtHour.TabIndex = 5;
            this.txtHour.Enter += new System.EventHandler(this.txtHour_Enter);
            this.txtHour.Leave += new System.EventHandler(this.txtHour_Leave);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(113, 58);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(48, 20);
            this.txtSecond.TabIndex = 7;
            this.txtSecond.Enter += new System.EventHandler(this.txtSecond_Enter);
            this.txtSecond.Leave += new System.EventHandler(this.txtSecond_Leave);
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(60, 58);
            this.txtMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(48, 20);
            this.txtMinute.TabIndex = 6;
            this.txtMinute.Enter += new System.EventHandler(this.txtMinute_Enter);
            this.txtMinute.Leave += new System.EventHandler(this.txtMinute_Leave);
            // 
            // grpAM_PM
            // 
            this.grpAM_PM.Controls.Add(this.rdoPM);
            this.grpAM_PM.Controls.Add(this.rdoAM);
            this.grpAM_PM.Location = new System.Drawing.Point(152, 109);
            this.grpAM_PM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAM_PM.Name = "grpAM_PM";
            this.grpAM_PM.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAM_PM.Size = new System.Drawing.Size(110, 81);
            this.grpAM_PM.TabIndex = 8;
            this.grpAM_PM.TabStop = false;
            this.grpAM_PM.Text = "AM/PM";
            // 
            // rdoPM
            // 
            this.rdoPM.AutoSize = true;
            this.rdoPM.Location = new System.Drawing.Point(16, 46);
            this.rdoPM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoPM.Name = "rdoPM";
            this.rdoPM.Size = new System.Drawing.Size(41, 17);
            this.rdoPM.TabIndex = 1;
            this.rdoPM.TabStop = true;
            this.rdoPM.Text = "PM";
            this.rdoPM.UseVisualStyleBackColor = true;
            // 
            // rdoAM
            // 
            this.rdoAM.AutoSize = true;
            this.rdoAM.Location = new System.Drawing.Point(16, 24);
            this.rdoAM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoAM.Name = "rdoAM";
            this.rdoAM.Size = new System.Drawing.Size(41, 17);
            this.rdoAM.TabIndex = 0;
            this.rdoAM.TabStop = true;
            this.rdoAM.Text = "AM";
            this.rdoAM.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(61, 136);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "00:00:00";
            // 
            // lblCurText
            // 
            this.lblCurText.AutoSize = true;
            this.lblCurText.Location = new System.Drawing.Point(22, 218);
            this.lblCurText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurText.Name = "lblCurText";
            this.lblCurText.Size = new System.Drawing.Size(0, 13);
            this.lblCurText.TabIndex = 10;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(126, 218);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(0, 13);
            this.lblCurrent.TabIndex = 11;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 337);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblCurText);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.grpAM_PM);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnMinute);
            this.Controls.Add(this.btnHour);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClockForm";
            this.Text = "ClockForm";
            this.Load += new System.EventHandler(this.ClockForm_Load);
            this.grpAM_PM.ResumeLayout(false);
            this.grpAM_PM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnHour;
        private System.Windows.Forms.Button btnMinute;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.GroupBox grpAM_PM;
        private System.Windows.Forms.RadioButton rdoPM;
        private System.Windows.Forms.RadioButton rdoAM;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurText;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Timer tmrTime;
    }
}

