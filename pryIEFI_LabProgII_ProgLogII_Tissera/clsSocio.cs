using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Net.Configuration;
using System.IO;

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
        private Int32 Cant;
        private Decimal Prom;
        private Decimal TotSal;
        private Decimal May;
        private Decimal Men;

        public Int32 Dni_Socio
        {
            get { return DniSocio; }
            set { DniSocio = value; }
        }

        public Int32 ID_Barrio
        {
            get { return CodBarrio; }
            set { CodBarrio = value; }
        }

        public Int32 ID_Actividad
        {
            get { return CodActividad; }
            set { CodActividad = value; }
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
        public Int32 Cantidad
        {
            get { return Cant; }
        }
        public Decimal Promedio
        {
            get { return Prom; }
        }
        public Decimal TotalSaldo
        {
            get { return TotSal; }
        }
        public Decimal Mayor
        {
            get { return May; }
        }
        public Decimal Menor
        {
            get { return Men; }
        }
        public Decimal PromedioDoble
        {
            get { return Prom; }
            set { Prom = value; }
        }
        public Decimal TotalSaldoDoble
        {
            get { return TotSal; }
            set { TotSal = value; }
        }
        public Decimal MayorDoble
        {
            get { return May; }
            set { May = value; }
        }
        public Decimal MenorDoble
        {
            get { return Men; }
            set { Men = value; }
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

        public void Modificar(Int32 Dni_Socio) //LOGRADO A MEDIAS (PENDIENTE DE REPARACIÓN)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Socio SET Nombre_Apellido = '" + NombreApellido + "', Direccion = '" +
                                        DetalleDireccion + "', Saldo = " + Saldo + " WHERE Dni_Socio = " + Dni_Socio;

                comando.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Datos actualizados con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                string SQLTablas, SQLComando;
                SQLTablas = "Dni_Socio, Nombre_Apellido, Direccion, Codigo_Barrio, Codigo_Actividad, Saldo";
                SQLComando = DniSocio + ", '" + NombreApellido + "', '" + DetalleDireccion + "', " + CodBarrio + ", " + CodActividad + ", " + Saldo;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Socio (" + SQLTablas + ") VALUES (" + SQLComando + ")";
                comando.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Socio cargado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.ToString());
            }
        }

        public void Calcular()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Socio;

                OleDbDataReader DR = comando.ExecuteReader();
                DR.Read();
                May = 0;
                Men = DR.GetDecimal(5);
                while (DR.Read())
                {
                    if (DR.GetDecimal(5) > May)
                    {
                        May = DR.GetDecimal(5);
                    }

                    if (DR.GetDecimal(5) < Men)
                    {
                        Men = DR.GetDecimal(5);
                    }

                    TotSal = TotSal + DR.GetDecimal(5);
                    Cant++;
                }
                conexion.Close();

                Prom = TotSal / Cant;
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.ToString());
            }
        }

        public void ListarActividad(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Socio;

                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                DR.Read();
                May = 0;
                Men = DR.GetDecimal(5);
                while (DR.Read())
                {
                    if (DR.GetInt32(4) == CodActividad)
                    {
                        Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1));

                        if (DR.GetDecimal(5) > May)
                        {
                            May = DR.GetDecimal(5);
                        }

                        if (DR.GetDecimal(5) < Men)
                        {
                            Men = DR.GetDecimal(5);
                        }

                        TotSal = TotSal + DR.GetDecimal(5);
                        Cant++;
                    }
                }

                Prom = TotSal / Cant;

                conexion.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.ToString());
            }
        }

        public void GenerarReporte(DataGridView Grilla)
        {
            try
            {
                Int32 fila = 0;
                string[] vecDatos = new string[2];

                if (Grilla.Rows.Count > 0)
                {
                    StreamWriter Reporte = new StreamWriter("Reporte.txt", false);

                    Reporte.WriteLine(DetalleActividad);
                    Reporte.WriteLine("");
                    Reporte.WriteLine("DNI      NOMBRE COMPLETO");

                    while (fila < Grilla.Rows.Count)
                    {
                        Reporte.WriteLine(Grilla.Rows[fila].Cells[0].Value + "      " + Grilla.Rows[fila].Cells[1].Value);
                        fila++;
                    }

                    Reporte.WriteLine("");
                    Reporte.WriteLine("Mayor saldo:     " + Saldo);
                    Reporte.WriteLine("Menor saldo:     " + Men);
                    Reporte.WriteLine("Promedio de saldos:     " + Prom);
                    Reporte.WriteLine("Total de saldos:     " + TotSal);

                    Reporte.Close();
                    
                    MessageBox.Show("Archivo Reporte.txt creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La grilla no tiene filas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.ToString());
            }
        }
    }
}
