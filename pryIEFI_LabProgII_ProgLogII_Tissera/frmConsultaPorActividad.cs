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
    public partial class frmConsultaPorActividad : Form
    {
        public frmConsultaPorActividad()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 Actividad = 0;

            if (cboActividad.Text == "")
            {
                MessageBox.Show("Debe seleccionar una actividad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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

                clsSocio socio = new clsSocio();
                socio.ID_Actividad = Actividad;
                socio.ListarActividad(dgvActividad);
                lblResMayor.Text = "$" + socio.Mayor.ToString("0,00");
                lblResMenor.Text = "$" + socio.Menor.ToString("0,00");
                lblResPromedio.Text = "$" + socio.Promedio.ToString("0,00");
                lblResTotal.Text = "$" + socio.TotalSaldo.ToString("0,00");
            } 
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvActividad.Rows.Count == 0)
            {
                MessageBox.Show("La grilla no tiene filas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clsSocio socio = new clsSocio();
                socio.LaActividad = cboActividad.Text;
                socio.TotalSaldoDoble = Convert.ToDecimal(lblResTotal.Text);
                socio.MayorDoble = Convert.ToDecimal(lblResMayor.Text);
                socio.MenorDoble = Convert.ToDecimal(lblResMenor.Text);
                socio.PromedioDoble = Convert.ToDecimal(lblResPromedio.Text);
                socio.GenerarReporte(dgvActividad);
            }  
        }
    }
}
