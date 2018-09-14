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
    public partial class Exercise6Form : Form
    {
        public Exercise6Form()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Fill in the Blank";
            this.Size = new Size(300, 150);
            this.WindowState = FormWindowState.Minimized;
            this.Opacity = 0.5;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            txtBlank.Location = new Point(227, 29);

            lblToto.Text = "Toto, I don't think we are in";
            lblToto.Location = new Point(12, 29);
            lblToto.Font = new Font("Verdana", 10); 


            lblQuote.Text = "A quote from the Wizard Of Oz";
            lblQuote.Location = new Point(65, 63);
            lblQuote.Font = new Font("Microsoft Sans Serif", 8); 
            
        }
    }
}
