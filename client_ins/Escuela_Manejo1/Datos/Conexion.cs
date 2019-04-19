using System;
using System.Data;
using MySql.Data.MySqlClient;
using Gtk;

namespace Escuela_Manejo1.Datos
{
    public class Conexion
    {
        #region
        private string cadena = String.Empty;
        private MySqlConnection conn { get; set; }
        private MySqlCommand sqlCommand { get; set; }
        private IDataReader idr { get; set; }
        #endregion

        #region
        public string CadenaConexion() 
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "manejo";
            sb.Database="escuela_manejo";
            sb.Password = "PurpleLamborghini";
            return sb.ConnectionString;
        
        }

        public void AbrirConexion()
        {
            MessageDialog ms = null;
            if(conn.State==ConnectionState.Open)
            {
                return;
            }
            else {

                conn.ConnectionString = cadena;
                try
                {
                    conn.Open();

                }
                catch (Exception e)
                {
                    ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, e.Message);
                    ms.Run();
                    ms.Destroy();

                }

            }

        }

        public void cerrarConexion()
        { 
            if(conn.State==ConnectionState.Closed)
            {
                return;
            
            }
            else {
                conn.Close();
            
            }

        }

        public Int32 Ejecutar(CommandType ct,string consultas)
        {
            int retorno = 0;
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = ct;
            sqlCommand.CommandText = consultas;
            try {
                retorno = sqlCommand.ExecuteNonQuery();
            }catch
            {
                throw;
            }
            return retorno;

        }

        public IDataReader Leer(CommandType ct,string consulta)
        {
            idr = null;
            sqlCommand.Connection = conn;
            sqlCommand.CommandType = ct;
            sqlCommand.CommandText = consulta;
            try
            {
                idr = sqlCommand.ExecuteReader();

            }
            catch {

                throw;
              
            }


            return idr;

        }

        #endregion


        public Conexion()
        {
            cadena = CadenaConexion();
            conn = new MySqlConnection();
            sqlCommand = new MySqlCommand();
        }
    }
}
