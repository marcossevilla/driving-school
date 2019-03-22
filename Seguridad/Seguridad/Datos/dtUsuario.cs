using System;
using System.Data;
using MySql.Data;
using Gtk;
using System.Text;
using Seguridad.entidades;

namespace Seguridad.Datos
{
    public class dtUsuario
    {
        Connection con = new Connection();

        public dtUsuario()
        {

        }

        public bool GuardarUsuario(Tbl_user tus)
        {
            bool guardado = false;
            int x = 0;
            MessageDialog ms = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO tbl_user");
            sb.Append("(user, pwd, nombres, apellidos, email, estado)");
            sb.Append("VALUES ('"+ tus.User + "','" + tus.Pwd + "','" + tus.Nombres + "','" + tus.Apellidos + "','" + tus.Email + "','" + 1 + "')");


            try
            {
                con.AbrirCOnexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if (x > 0)
                {
                    guardado = true;
                    /*ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Se guardo el usuario con exito");
                    ms.Run();
                    ms.Destroy();*/
                }

                return guardado;
            }catch(Exception e)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, e.Message);
                ms.Run(); 
                ms.Destroy();
            }

            return guardado;
        }

        public ListStore listar_usuarios()
        {
            ListStore datos = new ListStore(typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

            StringBuilder sb = new StringBuilder();

            MessageDialog ms = null;
            IDataReader dr = null;
            sb.Append("Select id_user,user,nombres,apellidos,email from tbl_user");

            try
            {
                con.AbrirCOnexion();
                dr = con.Leer(CommandType.Text, sb.ToString());
                while (dr.Read())
                {
                    datos.AppendValues(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }

                return datos;
            }catch(Exception e)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
            }
            finally
            {
                dr.Close();
                con.CerrarConexion();
            }

            return datos;
        }
    }
}
