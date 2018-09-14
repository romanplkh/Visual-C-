namespace IndivAssignement1
{
    partial class Exercise5Form
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
            this.lblWhite = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWhite
            // 
            this.lblWhite.BackColor = System.Drawing.Color.White;
            this.lblWhite.Location = new System.Drawing.Point(87, 42);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(291, 196);
            this.lblWhite.TabIndex = 0;
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(109, 66);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(242, 150);
            this.lblRed.TabIndex = 1;
            // 
            // lblYellow
            // 
            this.lblYellow.BackColor = System.Drawing.Color.Yellow;
            this.lblYellow.Location = new System.Drawing.Point(138, 92);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(189, 100);
            this.lblYellow.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(167, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 63);
            this.label1.TabIndex = 3;
            // 
            // Exercise5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblWhite);
            this.Name = "Exercise5Form";
            this.Text = "4 Rectangles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label label1;
    }
}