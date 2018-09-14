namespace IndivAssignement1
{
    partial class Exercise7Form
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
            this.lblBackground = new System.Windows.Forms.Label();
            this.lblForeground = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBackground
            // 
            this.lblBackground.AutoSize = true;
            this.lblBackground.Location = new System.Drawing.Point(30, 13);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(35, 13);
            this.lblBackground.TabIndex = 0;
            this.lblBackground.Text = "label1";
            // 
            // lblForeground
            // 
            this.lblForeground.AutoSize = true;
            this.lblForeground.Location = new System.Drawing.Point(30, 34);
            this.lblForeground.Name = "lblForeground";
            this.lblForeground.Size = new System.Drawing.Size(35, 13);
            this.lblForeground.TabIndex = 1;
            this.lblForeground.Text = "label2";
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(76, 13);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 34);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "button1";
            this.btnRed.UseVisualStyleBackColor = true;
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(158, 13);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 34);
            this.btnBlue.TabIndex = 3;
            this.btnBlue.Text = "button2";
            this.btnBlue.UseVisualStyleBackColor = true;
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(76, 63);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 35);
            this.btnYellow.TabIndex = 4;
            this.btnYellow.Text = "button3";
            this.btnYellow.UseVisualStyleBackColor = true;
            // 
            // btnWhite
            // 
            this.btnWhite.Location = new System.Drawing.Point(158, 63);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(75, 35);
            this.btnWhite.TabIndex = 5;
            this.btnWhite.Text = "button4";
            this.btnWhite.UseVisualStyleBackColor = true;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(102, 114);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            this.txtDay.TabIndex = 6;
            // 
            // Exercise7Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 153);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.lblForeground);
            this.Controls.Add(this.lblBackground);
            this.Name = "Exercise7Form";
            this.Text = "Exercise7Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.Label lblForeground;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.TextBox txtDay;
    }
}