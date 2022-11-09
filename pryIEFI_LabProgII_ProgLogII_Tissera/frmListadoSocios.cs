using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEFI_LabProgII_ProgLogII_Tissera
{
    public partial class frmListadoSocios : Form
    {
        public frmListadoSocios()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsSocio Socio = new clsSocio();
            Socio.Listar(dgvSocios);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
