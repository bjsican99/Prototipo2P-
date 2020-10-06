using CapaVista.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void matenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateriaPrima mp = new frmMateriaPrima();
            mp.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Billy Jeshua Sican Matias-0901-17-16250");
        }
    }
}
