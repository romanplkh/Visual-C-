using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseCalculationsAndVariables
{
    public partial class AutoRepairBill : Form
    {
        string outputGlobal = "";
        decimal labourCostGlobal = 0m;
        decimal partCostGlobal = 0m;
        decimal overallTaxes = 0m;
        int counter = 0;


        public AutoRepairBill()
        {
            InitializeComponent();
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            int i = 1;
            counter += i++;
            decimal taxPart = 1.05m;
            decimal provincialTax = 0.15m;
            decimal personPay = 35m;


            decimal labHours = decimal.Parse(txtLabor.Text);
            decimal partCost = decimal.Parse(txtPartCost.Text)*taxPart;
            string partName = txtPartName.Text;


            decimal workCost = labHours * personPay;
            decimal hst = (workCost + partCost) * provincialTax;


            partCostGlobal += partCost;
            labourCostGlobal += workCost;
            overallTaxes += hst;



            string output = Environment.NewLine + "----------ITEM #" + counter + "----------" + Environment.NewLine
                 + "Part name: " + partName + Environment.NewLine +
                 "Cost: " + partCost.ToString("C") + Environment.NewLine +
                 "Labour Amount: " + workCost.ToString("c") + Environment.NewLine +
                 "Tax: " + hst.ToString("c") + Environment.NewLine;


            outputGlobal += output;

            txtBill.Text = outputGlobal; 
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            decimal totalForAll = labourCostGlobal + partCostGlobal + overallTaxes;

            string output = Environment.NewLine + "----------YOU HAVE #" + counter + " ITEMS----------" + Environment.NewLine
                + "Total labour: " + labourCostGlobal.ToString("c") + Environment.NewLine +
                "Total parts: " + partCostGlobal.ToString("c") + Environment.NewLine +
                "Total taxes: " + overallTaxes.ToString("c") + Environment.NewLine +
                "TOTAL BILL: " + totalForAll.ToString("c");


            txtBill.Text = outputGlobal + output;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outputGlobal = "";
            labourCostGlobal = 0m;
            partCostGlobal = 0m;
            overallTaxes = 0m;
            counter = 0;

            txtBill.Text = String.Empty;
            txtPartName.Text = "";
            txtLabor.Text = "";
            txtPartCost.Text = "";
        }
    }
}
