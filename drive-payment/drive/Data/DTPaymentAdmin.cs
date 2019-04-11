using System;
using Gtk;
using drive.Connection;
using System.Data;
using System.Text;
using System.Collections.Generic;
using drive.Entity;

namespace drive.Data
{
    public class DTPaymentAdmin
    {
        StringBuilder sb = new StringBuilder();
        Connection.Connection con = new Connection.Connection();

        ListStore datos = new ListStore(typeof(string),
               typeof(string), typeof(string), typeof(string));

        public DTPaymentAdmin()
        {
            var conpaymentAd = new drive.Connection.Connection();

            conpaymentAd.AbrirCOnexion();
        }

        public ListStore getColumnsService(String course_service)
        {
           
            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("SELECT id_course_service, name, price, state FROM course_service WHERE name =" + "'" + course_service + "';");

            try
            {
                con.AbrirCOnexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    datos.AppendValues(idr[0].ToString(), idr[1].ToString(),
                        idr[2].ToString(), idr[3].ToString());
                    //dr.Close();
                }//fin de while
                return datos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                idr.Close();
                con.CerrarConexion();
            }
        }//fin del metodo
    }
}
