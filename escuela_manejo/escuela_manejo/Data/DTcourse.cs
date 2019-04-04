using System;
using System.Data;
using System.Text;
using Gtk;
namespace escuela_manejo.Data
{
    public class DTcourse
    {
        StringBuilder sb = new StringBuilder();
        Connection.Connection con = new Connection.Connection();
        MessageDialog ms = null;


        #region metodos
        public bool SaveCourse(Course cour)
        {
            bool guardado = false; //bandera
            int x = 0; //variable de control
            sb.Clear();
            sb.Append("INSERT INTO course ");
            sb.Append("(name,description)");
            sb.Append(" VALUES('" + cour.Name + "','" + cour.Description + "')");
            try
            {
                con.AbrirCOnexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if (x > 0)
                {
                    guardado = true;
                    ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Info, ButtonsType.Ok, "Se guardo el curso con exito!!!");
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

        public bool ExistUser(Course cour)
        {

            bool exist = false;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("SELECT * FROM course where name = " + "'" + cour.Name + "';");

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


        public ListStore ListCourse()
        {
            ListStore data = new ListStore(typeof(string),
                typeof(string), typeof(string), typeof(string), typeof(string));
            IDataReader dr = null;
            sb.Clear();
            sb.Append("SELECT id_course,name,description FROM course");
            try
            {
                con.AbrirCOnexion();
                dr = con.Leer(CommandType.Text, sb.ToString());
                while (dr.Read())
                {
                    data.AppendValues(dr[0].ToString(), dr[1].ToString(),
                        dr[2]);
                    //dr.Close();
                }//fin de while
                return data;
            }
            catch (Exception e)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            }
            finally
            {
                dr.Close();
                con.CerrarConexion();
            }
        }//fin del metodo


        public Int32 DeleteCour(Course tcour)
        {
            int delete;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("Delete from course WHERE id_course=" + tcour.Id_course + ";");

            try
            {
                con.AbrirCOnexion();
                delete = con.Ejecutar(CommandType.Text, sb.ToString());
                return delete;
            }
            catch (Exception e)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            }
            finally
            {
                con.CerrarConexion();
            }

        }//fin del metodo

        public bool UpdateCour(Course Tcour){

            bool update = false;

            int x = 0;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("UPDATE course SET name = '" + Tcour.Name + "',");
            sb.Append("description = '" + Tcour.Description + "'");
            sb.Append("WHERE id_course = " + Tcour.Id_course + ";");

            try
            {
                con.AbrirCOnexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if (x > 0)
                {
                    update = true;
                }
                //actualizado = cone.Ejecutar(CommandType.Text,sb.ToString());
                return update;
            }
            catch (Exception e)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            }
            finally
            {
                con.CerrarConexion();
            }

    }

        #endregion
    }
}
