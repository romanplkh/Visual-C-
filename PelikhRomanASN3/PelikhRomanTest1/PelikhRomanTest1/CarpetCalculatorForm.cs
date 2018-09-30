using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* Pelikh Roman */


namespace PelikhRomanTest1
{
    public partial class CarpetCalculatorForm : Form
    {
        decimal price = 5.99m;

        public CarpetCalculatorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Text = "Carpet Calculator";
            
        }

        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal carpetLength = Convert.ToDecimal(txtCarpetLength.Text);
                decimal carpetWidth = Convert.ToDecimal(txtCarpetWidth.Text);
                string carpetColor = txtCarpetColor.Text;


                decimal area = carpetLength * carpetWidth;
                decimal cost = price * area;

                lblAnswer.Text = "The Price for your" + Environment.NewLine + carpetColor + " carpet is: " + cost.ToString("c");
                MessageBox.Show(lblAnswer.Text);

                txtCarpetLength.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
                
            }
            finally
            {
                txtCarpetLength.Focus();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(Control textBox in this.Controls)
            {
                if(textBox is TextBox)
                {
                    textBox.Text = "";
                }
            }

            lblAnswer.Text = "";

            txtCarpetLength.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    

}
