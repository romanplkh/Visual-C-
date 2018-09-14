namespace IndivAssignement1
{
    partial class Exercise6Form
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
            this.txtBlank = new System.Windows.Forms.TextBox();
            this.lblQuote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblToto
            // 
            this.lblToto.AutoSize = true;
            this.lblToto.Location = new System.Drawing.Point(53, 47);
            this.lblToto.Name = "lblToto";
            this.lblToto.Size = new System.Drawing.Size(35, 13);
            this.lblToto.TabIndex = 0;
            this.lblToto.Text = "label1";
            // 
            // txtBlank
            // 
            this.txtBlank.Location = new System.Drawing.Point(44, 12);
            this.txtBlank.Name = "txtBlank";
            this.txtBlank.Size = new System.Drawing.Size(44, 20);
            this.txtBlank.TabIndex = 1;
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Location = new System.Drawing.Point(41, 80);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(35, 13);
            this.lblQuote.TabIndex = 2;
            this.lblQuote.Text = "label2";
            // 
            // Exercise6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 104);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.txtBlank);
            this.Controls.Add(this.lblToto);
            this.Name = "Exercise6Form";
            this.Text = "Exercise6Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToto;
        private System.Windows.Forms.TextBox txtBlank;
        private System.Windows.Forms.Label lblQuote;
    }
}