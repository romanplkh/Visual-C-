using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureSales
{
    public partial class FurnitureSalesForm : Form
    {
        private decimal commission = 0m;

        string output = "";
        decimal priceGlobal = 0m;


        public FurnitureSalesForm()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);

            string result = item + " : " + price.ToString("c") + Environment.NewLine;
            output += result;
            priceGlobal += price;

            lblDisplay.Text = output;

            txtItem.Focus();


        }

        private void btnShowCommission_Click(object sender, EventArgs e)
        {
            commission = priceGlobal * 0.07m;
            lblDisplay.Text = output + "Total comission : " + commission.ToString("c") + Environment.NewLine;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            output = "";
            priceGlobal = 0m;
            commission = 0m;

            txtItem.Text = String.Empty;
            txtPrice.Text = String.Empty;
            lblDisplay.Text = String.Empty;

            txtItem.Focus();

        }
    }
}
