namespace IndivAssignement1
{
    partial class Exercise1Form
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
            this.lblToto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQuote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblToto
            // 
            this.lblToto.AutoSize = true;
            this.lblToto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToto.Location = new System.Drawing.Point(15, 26);
            this.lblToto.Name = "lblToto";
            this.lblToto.Size = new System.Drawing.Size(182, 17);
            this.lblToto.TabIndex = 0;
            this.lblToto.Text = "Toto, I don\'t think we are in ";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.textBox1.Location = new System.Drawing.Point(210, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Location = new System.Drawing.Point(77, 71);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(151, 13);
            this.lblQuote.TabIndex = 2;
            this.lblQuote.Text = "A quote from the Wizard Of Oz";
            // 
            // Exercise1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblToto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercise1Form";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fill in the Blank";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblQuote;
    }
}

