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
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtBarrio.Enabled = false;
            txtActividad.Enabled = false;
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
                    txtBarrio.Text = socio.ElBarrio;
                    txtActividad.Text = socio.LaActividad;
                    txtSaldo.Text = socio.ElSaldo.ToString();

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
            txtBarrio.Enabled = true;
            txtActividad.Enabled = true;
            txtSaldo.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            //PENDIENTE
            clsSocio socio = new clsSocio();
            socio.ElSaldo = Convert.ToDecimal(txtSaldo.Text);
            socio.Modificar(Convert.ToInt32(txtDNI.Text));
            MessageBox.Show("Datos actualizados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
