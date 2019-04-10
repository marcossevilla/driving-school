using System;
using Gtk;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace escuela_manejo.Security_data
{
    public class DTuser
    {
        StringBuilder sb = new StringBuilder();
        Connection.Connection con = new Connection.Connection();
        MessageDialog ms = null;

        public DTuser()
        {
        }

        public bool SaveUser(User tus)
        {
            bool guardado = false; //bandera
            int x = 0; //variable de control
            sb.Clear();
            sb.Append("INSERT INTO User ");
            sb.Append("(user,pwd,first_name,last_name,email,state,id,phone)");
            sb.Append(" VALUES('" + tus.Username + "','" + tus.Pwd + "','" + tus.First_name + "','" + tus.Last_name + "','" + tus.Email + "','"  + tus.State + "','" + tus.Id + "','" + tus.Phone + "')");
            try
            {
                con.AbrirCOnexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if (x > 0)
                {
                    guardado = true;
                    ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Info, ButtonsType.Ok, "Se guardo el usuario con exito!!!");
                    ms.Run();
                    ms.Destroy();
                }
                return guardado;
            }
            catch (Exception e)
            {
                ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Error, ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            }
            finally
            {
                con.CerrarConexion();
            }

        }//fin del metodo



    }
}
