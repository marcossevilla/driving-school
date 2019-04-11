using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using Gtk;
using drive.Entity;

namespace drive.Data
{
    public class DTService
    {
        StringBuilder sb = new StringBuilder();
        Connection.Connection con = new Connection.Connection();

        public int getIdcourse(String course_service)
        {
            int existe = 0; //bandera
            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("SELECT id_course_service FROM course_service WHERE name =" + "'" + course_service + "';");

            try
            {
                con.AbrirCOnexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    existe = (Int32)idr["id_course_service"];
                }
                return existe;
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

        public bool ExistPayment(Payment tservices)
        {

            bool exist = false;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("SELECT * FROM course_service where name = " + "'" + tservices.Name + "';");

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


        public bool SaveService(CourseService tservices)
        {
            bool guardado = false; //bandera
            int x = 0; //variable de control

            sb.Clear();
            sb.Append("INSERT INTO course_service ");
            sb.Append("(id_course_operating,name,price,state)");
            sb.Append(" VALUES('" + tservices.Id_course_operating + "','" + tservices.Name + "','" + tservices.Price + "','" + 1 + "')");
            try
            {
                con.AbrirCOnexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if (x > 0)
                {
                    guardado = true;
                    var ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Info, ButtonsType.Ok, "Se guardo el curso con exito!!!");
                    ms.Run();
                    ms.Destroy();
                }
                return guardado;
            }
            catch (Exception e)
            {
                var ms = new MessageDialog(null, DialogFlags.Modal,
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

        public List<CourseService> cmbServiceType()
        {
            List<CourseService> listCourse = new List<CourseService>();
            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("SELECT id_course_service, name FROM course_service;");

            try
            {
                con.AbrirCOnexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    CourseService tcour = new CourseService()
                    //Tbl_usuarios tus = new Tbl_usuarios()
                    {
                        Id_course_service = (Int32)idr["id_course_service"],
                        Name = idr["name"].ToString(),

                    };
                    listCourse.Add(tcour);

                }
                idr.Close();
                return listCourse;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public DTService()
        {
        }
    }
}
