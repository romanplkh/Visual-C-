using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ThePayCalculator
{
    public partial class ThePayCalculator : Form
    {
        public ThePayCalculator()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(Control txtBox in this.Controls)
            {
                if(txtBox is TextBox || txtBox is Label 
                    && (txtBox.Name == "lblAnswer"  
                    || txtBox.Name == "lblOvertime")){
                    txtBox.Text = "";
                    
                }
            }

            txtHoursWorked.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MinimizeBox = false;
            this.MaximizeBox = false; 


           



            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try {


                string pattern = @"(\d+)";

                Match txtHoursWorkedDigits = Regex.Match(txtHoursWorked.Text, pattern);
                Match txtHoursRate = Regex.Match(txtHourRate.Text, pattern);

               // if (Tryparse.)


                if (txtHoursWorkedDigits.Success && txtHoursRate.Success)
                {

                    //Get input
                    decimal hoursWorked = decimal.Parse(txtHoursWorked.Text);
                    decimal payRate = decimal.Parse(txtHourRate.Text);
                    
                    //Create variables 
                    decimal netPay;
                    decimal grossPay;
                    decimal decuctionTax = 0.15m;
                    decimal hoursNormWorked = 40m;

                    if (hoursWorked > 40)
                    {


                        decimal overtimeHours = hoursWorked - hoursNormWorked;
                        decimal overtimePay = overtimeHours * (payRate * 1.5m);
                        lblOvertime.Text = overtimeHours.ToString();


                        decimal regularPay = hoursNormWorked * payRate;
                        grossPay = overtimePay + regularPay;
                        netPay = grossPay * (1 - decuctionTax);

                        lblAnswer.Text = "Your Gross Pay is " + grossPay.ToString("c")
                            + Environment.NewLine + "Your Net Pay is " + netPay.ToString("c");

                        MessageBox.Show(lblAnswer.Text);
                    }
                    else if (hoursWorked <= 40)
                    {

                        grossPay = hoursWorked * payRate;
                        netPay = grossPay * (1 - decuctionTax);

                        lblAnswer.Text = "Your Gross Pay is " + grossPay.ToString("c")
                            + Environment.NewLine + "Your Net Pay is " + netPay.ToString("c");

                        MessageBox.Show(lblAnswer.Text);
                    }


                } else 
                {
                    MessageBox.Show("TEXTBOX ACCEPTS DIGITS ONLY");
                    
                }


            } catch (Exception err)
            {
                MessageBox.Show("An error has occured: " + err.Message);
            }
            finally
            {
                txtHoursWorked.Focus();
            }


        }
    }
}
