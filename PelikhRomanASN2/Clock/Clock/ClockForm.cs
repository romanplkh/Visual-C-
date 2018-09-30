using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Roman Pelikh */


namespace Clock
{
    public partial class ClockForm : Form
    {
        public ClockForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblCurText.Text = "Current Date/Time: ";
        }

        private void ClockForm_Load(object sender, EventArgs e)
        {
            this.Text = "Alarm Clock";
            btnOn.ForeColor = Color.Green;
            btnOff.ForeColor = Color.Red;
            lblTime.BorderStyle = BorderStyle.Fixed3D;
            lblTime.BackColor = Color.Black;
            lblTime.ForeColor = Color.Silver;
            lblTime.Font = new Font(Font, FontStyle.Bold);
            lblTime.AutoSize = false;
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            lblTime.Size = new Size(75, 20);

            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Visible = false;
                }
            }

            foreach (Control y in this.Controls)
            {
                
                if (y is Button)
                {
                    ((Button)y).Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                }
            }


            btnHour.Enabled = false;
            btnMinute.Enabled = false;
            btnSecond.Enabled = false;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            Console.Beep(1000, 300);

            btnHour.Enabled = true;
            btnMinute.Enabled = true;
            btnSecond.Enabled = true;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnHour.Enabled = false;
            btnMinute.Enabled = false;
            btnSecond.Enabled = false;

            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Visible = false;
                    ((TextBox)x).Clear();

                }
            }

        }

        private void btnHour_Click(object sender, EventArgs e)
        {
            txtHour.Visible = true;
        }

        private void btnMinute_Click(object sender, EventArgs e)
        {
            txtMinute.Visible = true;
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            txtSecond.Visible = true;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            string hour;
            string minute;
            string second; 

            Console.Beep(1500, 800);
            rdoAM.Checked = true;
            hour = txtHour.Text;
            minute = txtMinute.Text;
            second = txtSecond.Text;

            if ((txtHour.Text == "") && (txtMinute.Text == "") && (txtSecond.Text == ""))
            {
                lblTime.Text = "12:00:00";
            }
            else
            {
                lblTime.Text = hour + ":" + minute + ":" + second;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTime.Text = "00:00:00";
            rdoAM.Checked = false;
            rdoPM.Checked = false;

            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Visible = true;
                    ((TextBox)x).Clear();

                }
            }

            btnHour.Enabled = false;
            btnMinute.Enabled = false;
            btnSecond.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHour_Enter(object sender, EventArgs e)
        {
            txtHour.BackColor = Color.Yellow;
        }

        private void txtMinute_Enter(object sender, EventArgs e)
        {
            txtMinute.BackColor = Color.Yellow;
        }

        private void txtSecond_Enter(object sender, EventArgs e)
        {
            txtSecond.BackColor = Color.Yellow;
        }

        private void txtHour_Leave(object sender, EventArgs e)
        {
            txtHour.BackColor = Color.White;
        }

        private void txtMinute_Leave(object sender, EventArgs e)
        {
            txtMinute.BackColor = Color.White;
        }

        private void txtSecond_Leave(object sender, EventArgs e)
        {
            txtSecond.BackColor = Color.White;
        }

        

        private void tmrTime_Tick(object sender, EventArgs e)  
        {
            DateTime today = DateTime.Now;
            var hm = new DateTime(today.Year, today.Month, today.Day, today.Hour, today.Minute, today.Second);

            lblCurrent.Text = hm.ToString();

            tmrTime.Start();
        }
    }
}
