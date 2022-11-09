using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEFI_LabProgII_ProgLogII_Tissera
{
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        public Int32 Barrio = 0, Actividad = 0;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtSaldo.Enabled = false;

            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
            }
            else
            {
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtBarrio.Text = "";
                txtActividad.Text = "";
                txtSaldo.Text = "";

                clsSocio socio = new clsSocio();

                socio.Buscar(Convert.ToInt32(txtDNI.Text));

                if (socio.Dni_Socio == 0)
                {
                    MessageBox.Show("Socio no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDNI.Text = "";
                    txtDNI.Focus();
                }
                else
                {
                    txtNombre.Text = socio.Nombre_Apellido;
                    txtDireccion.Text = socio.Direccion;
                    txtSaldo.Text = socio.ElSaldo.ToString();
                    txtActividad.Text = socio.LaActividad;
                    txtBarrio.Text = socio.ElBarrio;

                    btnModificar.Enabled = true;
                    btnBorrar.Enabled = true;
                }
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = true;
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtSaldo.Enabled = true;
            btnBuscar.Enabled = false;
            txtDNI.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "" || txtSaldo.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clsSocio socio = new clsSocio();
                socio.ElSaldo = Convert.ToDecimal(txtSaldo.Text);
                socio.Nombre_Apellido = txtNombre.Text;
                socio.Direccion = txtDireccion.Text;
                socio.Modificar(Convert.ToInt32(txtDNI.Text));
                txtDNI.Enabled = true;
                btnBuscar.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            clsSocio socio = new clsSocio();
            
            DialogResult result = MessageBox.Show("¿Seguro que desea borrar este socio del registro?.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                socio.Eliminar(Convert.ToInt32(txtDNI.Text));
                MessageBox.Show("Socio eliminado del registro exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtBarrio.Text = "";
                txtActividad.Text = "";
                txtSaldo.Text = "";
                txtDNI.Text = "";
                txtDNI.Focus();
            }
            else
            {
                MessageBox.Show("Se ha cancelado la acción.", "Aviso");
            } 
        }
    }
}
