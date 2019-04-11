using System.Data;
using System.Text;
using System;
using Gtk;
using escuela_manejo;
using System.Collections.Generic;

namespace escuela_manejo.Security_data
{
    public class DTrol
    {
        StringBuilder sb = new StringBuilder();
        Connection.Connection con = new Connection.Connection();
        MessageDialog ms = null;

        public DTrol()
        {
        }

        public bool Saverol(escuela_manejo.Rol trol)
        {
            bool guardado = false; //bandera
            int x = 0; //variable de control
            sb.Clear();
            sb.Append("INSERT INTO Rol ");
            sb.Append("(Rol,state)");
            sb.Append(" VALUES('" + trol.Rols + "','" + trol.State + "')");
            try
            {
                con.AbrirCOnexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if (x > 0)
                {
                    guardado = true;
                    ///ms = new MessageDialog(null, DialogFlags.Modal,
                    //MessageType.Info, ButtonsType.Ok, "Se guardo el usuario con exito!!!");
                    //ms.Run();
                    //ms.Destroy();
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
