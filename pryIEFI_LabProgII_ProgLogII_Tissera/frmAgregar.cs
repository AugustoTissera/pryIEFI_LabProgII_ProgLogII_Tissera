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

        private void btnAgregar_Click(object sender, EventArgs e) //PENDIENTE
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "" || cboActividad.Text == "" || cboBarrio.Text == "" || txtSaldo.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Int32 Barrio = 0, Actividad = 0;

                if (cboActividad.Text == "Musculación")
                {
                    Actividad = 1;
                }
                else if (cboActividad.Text == "Crossfit")
                {
                    Actividad = 2;
                }
                else if (cboActividad.Text == "Pilates")
                {
                    Actividad = 3;
                }
                else if (cboActividad.Text == "Yoga")
                {
                    Actividad = 4;
                }
                else if (cboActividad.Text == "Cardio")
                {
                    Actividad = 5;
                }
                else if (cboActividad.Text == "Funcional")
                {
                    Actividad = 6;
                }

                if (cboBarrio.Text == "Nueva Córdoba")
                {
                    Barrio = 1;
                }
                else if (cboBarrio.Text == "Alta Córdoba")
                {
                    Barrio = 2;
                }
                else if (cboBarrio.Text == "Barrio Parque")
                {
                    Barrio = 3;
                }
                else if (cboBarrio.Text == "San Fernando")
                {
                    Barrio = 4;
                }
                else if (cboBarrio.Text == "Nueva Italia")
                {
                    Barrio = 5;
                }
                else if (cboBarrio.Text == "San Vicente")
                {
                    Barrio = 6;
                }
                else if (cboBarrio.Text == "General Paz")
                {
                    Barrio = 7;
                }
                else if (cboBarrio.Text == "Maipú")
                {
                    Barrio = 8;
                }
                else if (cboBarrio.Text == "Villa Allende")
                {
                    Barrio = 9;
                }
                else if (cboBarrio.Text == "Cerro de las Rosas")
                {
                    Barrio = 10;
                }

                clsSocio socio = new clsSocio();
                socio.Dni_Socio = Convert.ToInt32(txtDNI.Text);
                socio.Nombre_Apellido = txtNombre.Text;
                socio.Direccion = txtDireccion.Text;
                socio.ID_Barrio = Barrio;
                socio.ID_Actividad = Actividad;
                socio.ElSaldo = Convert.ToDecimal(txtSaldo.Text);
                socio.Agregar();

                txtDNI.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtSaldo.Text = "";
                cboActividad.Text = "";
                cboBarrio.Text = "";
                txtDNI.Focus();
            }   
        }
    }
}
