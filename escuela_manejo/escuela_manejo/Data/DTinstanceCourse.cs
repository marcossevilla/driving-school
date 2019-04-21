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
                sb.Append("INSERT INTO course_operating ");
                sb.Append("(id_course,id_instructor,id_vehicle,id_customer,start_date,end_date)");
                sb.Append(" VALUES('" + ins.Id_course + "','" + ins.Id_instructor  + "','" + ins.Id_vehicle + "','" + ins.Id_customer + "','" + ins.Start_date + "','" + ins.End_date + "')");
                try
                {
                    con.AbrirCOnexion();
                    x = con.Ejecutar(CommandType.Text, sb.ToString());

                    if (x > 0)
                    {
                        guardado = true;
                         ms = new MessageDialog(null,DialogFlags.Modal,
                         MessageType.Info,ButtonsType.Ok,"Se guardo el curso con exito!!!");
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


        public bool ExistUser(CourseOperating courseOp)
        {

            bool exist = false;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("SELECT * FROM course_operating where id_course = " + "'" + courseOp.Id_course  + "'AND id_instructor ='" + courseOp.Id_instructor + "'AND id_vehicle ='" + courseOp.Id_vehicle + "'AND id_customer ='" + courseOp.Id_customer + "'AND start_date ='" + courseOp.Start_date + "'AND end_date ='" + courseOp.End_date + "';");

            try
            {
                con.AbrirCOnexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    exist = true;
                }
                return exist;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }

            finally
            {
                if (idr != null)
                {
                    idr.Close();
                }
                con.CerrarConexion();
            }
        }





        #endregion

    }
}

