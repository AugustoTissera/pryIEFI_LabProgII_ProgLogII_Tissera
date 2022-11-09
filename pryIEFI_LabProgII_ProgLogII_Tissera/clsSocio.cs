using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Net.Configuration;

namespace pryIEFI_LabProgII_ProgLogII_Tissera
{
    internal class clsSocio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.mdb";
        private string Socio = "Socio";
        private string Barrio = "Barrio";
        private string Actividad = "Actividad";

        private Int32 DniSocio;
        private String NombreApellido;
        private String DetalleDireccion;
        private Int32 CodBarrio;
        private Int32 CodActividad;
        private Decimal Saldo;
        private String DetalleActividad;
        private String DetalleBarrio;

        public Int32 Dni_Socio
        {
            get { return DniSocio; }
            set { DniSocio = value; }
        }
        public String Nombre_Apellido
        {
            get { return NombreApellido; }
            set { NombreApellido = value; }
        }
        public String Direccion
        {
            get { return DetalleDireccion; }
            set { DetalleDireccion = value; }
        }
        public String ElBarrio
        {
            get { return DetalleBarrio; }
            set { DetalleBarrio = value; }
        }
        public String LaActividad
        {
            get { return DetalleActividad; }
            set { DetalleActividad = value; }
        }
        public Decimal ElSaldo
        {
            get { return Saldo; }
            set { Saldo = value; }
        }
        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Socio;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS);

                Grilla.DataSource = DS.Tables[0];

                conexion.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.ToString());
            }
        }

        public void Buscar(Int32 Dni_Socio)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Socio;

                OleDbDataReader DRSocio = comando.ExecuteReader();
                
                if (DRSocio.HasRows)
                {
                    while (DRSocio.Read())
                    {
                        if (DRSocio.GetInt32(0) == Dni_Socio)
                        {
                            DniSocio = DRSocio.GetInt32(0);
                            NombreApellido = DRSocio.GetString(1);
                            Direccion = DRSocio.GetString(2);
                            CodBarrio = DRSocio.GetInt32(3);
                            CodActividad = DRSocio.GetInt32(4);
                            Saldo = DRSocio.GetDecimal(5);
                        }
                    }
                }
                conexion.Close();

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Actividad;
                OleDbDataReader DRActividad = comando.ExecuteReader();

                if (DRActividad.HasRows)
                {
                    while (DRActividad.Read())
                    {
                        if (DRActividad.GetInt32(0) == CodActividad)
                        {
                            DetalleActividad = DRActividad.GetString(1);
                        }
                    }
                }
                conexion.Close();

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Barrio;
                OleDbDataReader DRBarrio = comando.ExecuteReader();
                
                if (DRBarrio.HasRows)
                {
                    while (DRBarrio.Read())
                    {
                        if (DRBarrio.GetInt32(0) == CodBarrio)
                        {
                            DetalleBarrio = DRBarrio.GetString(1);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.ToString());
            }
        }

        public void Modificar(Int32 Dni_Socio) //PENDIENTE
        {
            try
            {
                string SQLNombre, SQLDireccion, SQLBarrio, SQLActividad, SQLSaldo;
                SQLNombre = "UPDATE Socio SET Nombre_Apellido = " + NombreApellido + " WHERE Dni_Socio = " + Dni_Socio;
                SQLDireccion = "UPDATE Socio SET Direccion = " + DetalleDireccion + " WHERE Dni_Socio = " + Dni_Socio;
                SQLBarrio = "UPDATE Socio SET Codigo_Barrio = " + ElBarrio + " WHERE Dni_Socio = " + Dni_Socio;
                SQLActividad = "UPDATE Socio SET Codigo_Actividad = " + LaActividad + " WHERE Dni_Socio = " + Dni_Socio;
                SQLSaldo = "UPDATE Socio SET Saldo = " + Saldo + " WHERE Dni_Socio = " + Dni_Socio;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = SQLSaldo;
                comando.ExecuteNonQuery();

                comando.CommandText = SQLNombre;
                comando.ExecuteNonQuery();

                comando.CommandText = SQLDireccion;
                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.ToString());
            }

        }
    
        public void Eliminar(Int32 Dni_Socio)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE * FROM Socio WHERE Dni_Socio = " + Dni_Socio;
                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.ToString());
            }
            
            
        }
    
        public void Agregar()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE * FROM Socio WHERE Dni_Socio = " + Dni_Socio;
                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.ToString());
            }
        }
    }
}
