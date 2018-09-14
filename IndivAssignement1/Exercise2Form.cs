using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndivAssignement1
{
    public partial class Exercise2Form : Form
    {
        public Exercise2Form()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            txtDay.BackColor = Color.Red;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            txtDay.BackColor = Color.Blue;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            txtDay.ForeColor = Color.Yellow;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            txtDay.ForeColor = Color.White;
        }
    }
}
