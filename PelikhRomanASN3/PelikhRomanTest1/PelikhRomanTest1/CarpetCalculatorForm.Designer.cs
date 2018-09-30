namespace PelikhRomanTest1
{
    partial class CarpetCalculatorForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblCarpetLength = new System.Windows.Forms.Label();
            this.lblCarpetWidth = new System.Windows.Forms.Label();
            this.lblCarpetColor = new System.Windows.Forms.Label();
            this.txtCarpetLength = new System.Windows.Forms.TextBox();
            this.txtCarpetWidth = new System.Windows.Forms.TextBox();
            this.txtCarpetColor = new System.Windows.Forms.TextBox();
            this.pctCarpet = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarpet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(44, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "The Carpet Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.White;
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(24, 206);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(229, 66);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarpetLength
            // 
            this.lblCarpetLength.AutoSize = true;
            this.lblCarpetLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarpetLength.Location = new System.Drawing.Point(21, 105);
            this.lblCarpetLength.Name = "lblCarpetLength";
            this.lblCarpetLength.Size = new System.Drawing.Size(125, 13);
            this.lblCarpetLength.TabIndex = 2;
            this.lblCarpetLength.Text = "Enter Carpet Length:";
            // 
            // lblCarpetWidth
            // 
            this.lblCarpetWidth.AutoSize = true;
            this.lblCarpetWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarpetWidth.Location = new System.Drawing.Point(22, 136);
            this.lblCarpetWidth.Name = "lblCarpetWidth";
            this.lblCarpetWidth.Size = new System.Drawing.Size(119, 13);
            this.lblCarpetWidth.TabIndex = 3;
            this.lblCarpetWidth.Text = "Enter Carpet Width:";
            // 
            // lblCarpetColor
            // 
            this.lblCarpetColor.AutoSize = true;
            this.lblCarpetColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarpetColor.Location = new System.Drawing.Point(22, 167);
            this.lblCarpetColor.Name = "lblCarpetColor";
            this.lblCarpetColor.Size = new System.Drawing.Size(115, 13);
            this.lblCarpetColor.TabIndex = 4;
            this.lblCarpetColor.Text = "Enter Carpet Color:";
            // 
            // txtCarpetLength
            // 
            this.txtCarpetLength.Location = new System.Drawing.Point(153, 102);
            this.txtCarpetLength.Name = "txtCarpetLength";
            this.txtCarpetLength.Size = new System.Drawing.Size(100, 20);
            this.txtCarpetLength.TabIndex = 0;
            // 
            // txtCarpetWidth
            // 
            this.txtCarpetWidth.Location = new System.Drawing.Point(153, 133);
            this.txtCarpetWidth.Name = "txtCarpetWidth";
            this.txtCarpetWidth.Size = new System.Drawing.Size(100, 20);
            this.txtCarpetWidth.TabIndex = 1;
            // 
            // txtCarpetColor
            // 
            this.txtCarpetColor.Location = new System.Drawing.Point(153, 164);
            this.txtCarpetColor.Name = "txtCarpetColor";
            this.txtCarpetColor.Size = new System.Drawing.Size(100, 20);
            this.txtCarpetColor.TabIndex = 2;
            // 
            // pctCarpet
            // 
            this.pctCarpet.Image = global::PelikhRomanTest1.Properties.Resources.Carpet;
            this.pctCarpet.Location = new System.Drawing.Point(319, 102);
            this.pctCarpet.Name = "pctCarpet";
            this.pctCarpet.Size = new System.Drawing.Size(187, 107);
            this.pctCarpet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCarpet.TabIndex = 8;
            this.pctCarpet.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(273, 253);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 29);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(352, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(431, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(530, 307);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pctCarpet);
            this.Controls.Add(this.txtCarpetColor);
            this.Controls.Add(this.txtCarpetWidth);
            this.Controls.Add(this.txtCarpetLength);
            this.Controls.Add(this.lblCarpetColor);
            this.Controls.Add(this.lblCarpetWidth);
            this.Controls.Add(this.lblCarpetLength);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCarpet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblCarpetLength;
        private System.Windows.Forms.Label lblCarpetWidth;
        private System.Windows.Forms.Label lblCarpetColor;
        private System.Windows.Forms.TextBox txtCarpetLength;
        private System.Windows.Forms.TextBox txtCarpetWidth;
        private System.Windows.Forms.TextBox txtCarpetColor;
        private System.Windows.Forms.PictureBox pctCarpet;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

