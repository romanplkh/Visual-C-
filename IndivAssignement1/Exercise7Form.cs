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
    public partial class Exercise7Form : Form
    {
        public Exercise7Form()
        {
            InitializeComponent();

            //Window object
            this.BackColor = Color.Yellow;
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Colorful Text";



            lblBackground.BackColor = Color.Transparent;
            lblBackground.Text = "Background";
            lblBackground.Location = new Point(30, 13);

            lblForeground.BackColor = Color.Transparent;
            lblForeground.Text = "Foreground";
            lblForeground.Location = new Point(30, 114);


            txtDay.Text = "Beautiful Day";
            txtDay.Multiline = true;
            txtDay.Size = new Size(300, 30);
            txtDay.TextAlign = HorizontalAlignment.Center;
            txtDay.Location = new Point(51, 67);

            btnRed.Text = "Red";
            btnRed.Size = new Size(75, 34);
            btnRed.Location = new Point(158, 13);

            btnBlue.Text = "Blue";
            btnBlue.Size = new Size(75, 34);
            btnBlue.Location = new Point(273, 13);

            btnYellow.Text = "Yellow";
            btnYellow.Size = new Size(75, 34);
            btnYellow.Location = new Point(158, 114);



            btnWhite.Text = "White";
            btnWhite.Size = new Size(75, 34);
            btnWhite.Location = new Point(273, 114);














        }
    }
}
