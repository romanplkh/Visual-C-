namespace IndivAssignement1
{
    partial class Exercise2Form
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
            this.lblBackground.BackColor = System.Drawing.Color.Transparent;
            this.lblBackground.Location = new System.Drawing.Point(61, 18);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(65, 13);
            this.lblBackground.TabIndex = 0;
            this.lblBackground.Text = "Background";
            // 
            // lblForeground
            // 
            this.lblForeground.AutoSize = true;
            this.lblForeground.BackColor = System.Drawing.Color.Transparent;
            this.lblForeground.Location = new System.Drawing.Point(65, 105);
            this.lblForeground.Name = "lblForeground";
            this.lblForeground.Size = new System.Drawing.Size(61, 13);
            this.lblForeground.TabIndex = 1;
            this.lblForeground.Text = "Foreground";
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(181, 12);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(58, 29);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(265, 12);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(58, 29);
            this.btnBlue.TabIndex = 3;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(181, 105);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(58, 29);
            this.btnYellow.TabIndex = 4;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.Location = new System.Drawing.Point(265, 105);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(58, 29);
            this.btnWhite.TabIndex = 5;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(78, 53);
            this.txtDay.Multiline = true;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(245, 37);
            this.txtDay.TabIndex = 6;
            this.txtDay.Text = "Beautiful Day";
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Exercise2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.lblForeground);
            this.Controls.Add(this.lblBackground);
            this.Name = "Exercise2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise2Form";
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