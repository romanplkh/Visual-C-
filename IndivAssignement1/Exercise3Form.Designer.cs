namespace IndivAssignement1
{
    partial class Exercise3Form
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
            this.btnBatman = new System.Windows.Forms.Button();
            this.btnRobin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBatman
            // 
            this.btnBatman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatman.Location = new System.Drawing.Point(54, 29);
            this.btnBatman.Name = "btnBatman";
            this.btnBatman.Size = new System.Drawing.Size(75, 50);
            this.btnBatman.TabIndex = 0;
            this.btnBatman.Text = "Batman";
            this.btnBatman.UseVisualStyleBackColor = true;
            this.btnBatman.Click += new System.EventHandler(this.btnBatman_Click);
            // 
            // btnRobin
            // 
            this.btnRobin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRobin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobin.Location = new System.Drawing.Point(54, 84);
            this.btnRobin.Name = "btnRobin";
            this.btnRobin.Size = new System.Drawing.Size(75, 50);
            this.btnRobin.TabIndex = 1;
            this.btnRobin.Text = "Robin";
            this.btnRobin.UseVisualStyleBackColor = true;
            this.btnRobin.Click += new System.EventHandler(this.btnRobin_Click);
            // 
            // Exercise3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.btnRobin);
            this.Controls.Add(this.btnBatman);
            this.Name = "Exercise3Form";
            this.Text = "Batman and Robin";
            this.ResumeLayout(false);

        }

        #endregion


        
        private System.Windows.Forms.Button btnBatman;
        private System.Windows.Forms.Button btnRobin;
    }
}