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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSocios TodosSocios = new frmListadoSocios();
            TodosSocios.ShowDialog();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificar Modificar = new frmModificar();
            Modificar.ShowDialog();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar Agregar = new frmAgregar();
            Agregar.ShowDialog();
        }

        private void porActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPorActividad Actividad = new frmConsultaPorActividad();
            Actividad.ShowDialog();
        }
    }
}
