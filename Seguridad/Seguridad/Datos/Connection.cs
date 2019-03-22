using System;
using System.Data;
using MySql.Data.MySqlClient;
using Gtk;

namespace Seguridad.Datos
{
    public class Connection
    {

        #region atributos
        private string cadena = String.Empty;
        private MySqlConnection con { get; set; }
        private MySqlCommand sqlcommand { get; set; }
        private IDataReader Idr { get; set; }
        #endregion

        #region constructor
        public Connection()
        {
            cadena = cadenaConexion();
            con = new MySqlConnection();
            sqlcommand = new MySqlCommand();
        }
        #endregion

        #region metodos
        public string cadenaConexion()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Database = "Seguridad";
            sb.Password = "LabDes2019*";
            return sb.ConnectionString;
        }

        public void AbrirCOnexion()
        {
            MessageDialog ms = null;
            if(con.State == ConnectionState.Open)
            {
                return;
            }
            else
            {
                con.ConnectionString = cadena;
                try
                {
                   
                    con.Open();
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Se abrio la conexion a la BD seguridad");
                    ms.Run();
                    ms.Destroy();
                }
                catch(Exception e)
                {
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, e.Message);
                    ms.Run();
                    ms.Destroy();
                }
            }
        }

        public void CerrarConexion()
        {
            if(con.State == ConnectionState.Closed)
            {
                return;
            }
            else
            {
                con.Close();
            }
        }

        public Int32 Ejecutar(CommandType ct,string consulta)
        {
            int retorno = 0;
            sqlcommand.Connection = con;
            sqlcommand.CommandType = ct;
            sqlcommand.CommandText = consulta;

            try
            {
                retorno = sqlcommand.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }
           return retorno;
        }

        public IDataReader Leer(CommandType ct,string consulta)
        {
            Idr = null;
            sqlcommand.Connection = con;
            sqlcommand.CommandType = ct;
            sqlcommand.CommandText = consulta;

            try
            {
               Idr = sqlcommand.ExecuteReader();
            }
            catch
            {
                throw;
            }

            return Idr;
        }
        #endregion




    }
}
