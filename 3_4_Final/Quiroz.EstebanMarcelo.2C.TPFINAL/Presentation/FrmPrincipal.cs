using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConstruir_Click(object sender, EventArgs e)
        {
            FrmConstruir frmConstruir = new FrmConstruir();
            frmConstruir.ShowDialog();
        }

        private void btnMateriaPrima_Click(object sender, EventArgs e)
        {
            FrmMateriaPrima frmMateriaPrima = new FrmMateriaPrima();
            frmMateriaPrima.ShowDialog();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FrmInformes frmInformes = new FrmInformes();
            frmInformes.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda frmAyuda = new FrmAyuda();
            frmAyuda.ShowDialog();
        }
    }
}
