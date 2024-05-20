using pryMuñozLab3TP1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMuñozLab3TP1
{
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmReservas_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panelAsiento = new Panel();
            int nro = 1;
            PictureBox AsientosVerdes = new PictureBox();
            AsientosVerdes.Image = Image.FromFile("asiento verde.png");
            panelAsiento.Controls.Add(AsientosVerdes);
            Label lblNumero = new Label();
            lblNumero.Text = nro.ToString();
            panelAsiento.Controls.Add(lblNumero);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
