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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsSocio socio = new clsSocio();
            socio.Dni_Socio = Convert.ToInt32(txtDNI.Text);
            socio.Nombre_Apellido = txtNombre.Text;
            socio.Direccion = txtDireccion.Text;
            socio.ElBarrio = txtBarrio.Text;
            socio.LaActividad = txtActividad.Text;
            socio.Agregar();
        }
    }
}
