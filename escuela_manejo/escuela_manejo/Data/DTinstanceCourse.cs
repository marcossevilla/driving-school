using System;
using escuela_manejo.Connection;
using System.Text;
using Gtk;
using System.Data;

namespace escuela_manejo.Data
{
    public class DTinstanceCourse
    {
        StringBuilder sb = new StringBuilder();
        Connection.Connection con = new Connection.Connection();
        MessageDialog ms = null;

     
            #region metodos
            public bool SaveCourseOperating(CourseOperating ins)
            {
                bool guardado = false; //bandera
                int x = 0; //variable de control
                sb.Clear();
                sb.Append("INSERT INTO ");
                sb.Append("(id_course_operating,id_course,id_instructor,id_vehicle,id_customer,start_date,end_date)");
                //sb.Append(" VALUES('" + ins.User + "','" + tus.Pwd + "','" + tus.Nombres + "','" + tus.Apellidos + "','" + tus.Email + "','" + 1 + "')");
                try
                {
                    con.AbrirCOnexion();
                    x = con.Ejecutar(CommandType.Text, sb.ToString());

                    if (x > 0)
                    {
                        guardado = true;
                         ms = new MessageDialog(null,DialogFlags.Modal,
                         MessageType.Info,ButtonsType.Ok,"Se guardo el usuario con exito!!!");
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





        #endregion

    }
}

