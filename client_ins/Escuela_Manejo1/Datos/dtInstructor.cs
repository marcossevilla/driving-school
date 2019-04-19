using System;
using System.Data;
using MySql.Data;
using Gtk;
using System.Text;
using Escuela_Manejo1.entidades;

namespace Escuela_Manejo1.Datos
{
    public class dtInstructor
    {

        Conexion conn = new Conexion();
        MessageDialog mn = null;
        StringBuilder sb = new StringBuilder();
        #region
        public bool GuardarInstructor(Instructor Ins)
        {
            bool guardado = false;
            int n = 0;
            sb.Clear();
            sb.Append("INSERT INTO instructor");
            sb.Append("(first_name,last_name,email,phone,id,address,state)");
            sb.Append(" VALUES('" + Ins.First_name + "','" + Ins.Last_name + "','" + Ins.Email + "','" + Ins.Phone + "','" + Ins.Id + "','"+ Ins.Phone+ "','" + 1 + "')"); //+ "," + cus.Create_date + "," + cus.Last_update//
            Console.WriteLine("cadena insert " + sb.ToString());
            try
            {
                conn.AbrirConexion();
                n = conn.Ejecutar(CommandType.Text, sb.ToString());



                if (n > 0)
                {
                    guardado = true;
                }


                return guardado;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error insert " + sb.ToString());
                mn = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, e.Message);
                mn.Run();
                mn.Destroy();
                throw;

            }
            finally
            {
                conn.cerrarConexion();
            }


        }

        public ListStore listarInstructor()
        {
            ListStore datos = new ListStore(typeof(string),
                typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));
            IDataReader dr = null;
            sb.Clear();
            sb.Append("SELECT id_instructor,first_name,last_name,email,phone,id,address FROM instructor WHERE state <> '2'");
            try
            {
                conn.AbrirConexion();
                dr = conn.Leer(CommandType.Text, sb.ToString());
                while (dr.Read())
                {
                    datos.AppendValues(dr[0].ToString(), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),dr[5].ToString(),dr[6].ToString());

                }
                return datos;
            }
            catch (Exception e)
            {
                mn = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                mn.Run();
                mn.Destroy();
                throw;
            }
            finally
            {
                dr.Close();
                conn.cerrarConexion();
            }                                   //id      first          last           email            address      id                   phone 

        }


        public bool existeInstructor(Instructor ins)
        {
            bool existe = false;
            IDataReader r = null;
            sb.Clear();
            sb.Append("use escuela_manejo;");
            sb.Append("select *from instructor where id = " + "'" + ins.Id + "';");
            try
            {
                conn.AbrirConexion();
                r = conn.Leer(CommandType.Text, sb.ToString());
                if (r.Read())
                {
                    existe = true;
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
                r.Close();
                conn.cerrarConexion();

            }

        }

        public Int32 EliminarInstructor(Instructor ins)
        {
            int eliminado;
            sb.Clear();
            sb.Append("use escuela_manejo;");
            sb.Append("update instructor set state = '2' WHERE id= '" + ins.Id + "';");
            Console.WriteLine(sb.ToString());
            //update customer set state= '2' where id= 'id';
            try
            {
                conn.AbrirConexion();
                eliminado = conn.Ejecutar(CommandType.Text, sb.ToString());
                return eliminado;
            }
            catch (Exception e)
            {
                mn = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, e.Message);
                mn.Run();
                mn.Destroy();
                throw;
            }
        }

        public bool actualizar(Instructor ins)
        {
            bool actualizado = false;
            int n = 0;
            sb.Clear();
            sb.Append("use escuela_manejo;");
            sb.Append("update instructor set first_name= '" + ins.First_name + "',");
            sb.Append("last_name= '" + ins.Last_name + "',");
            sb.Append("email= '" + ins.Email + "',");
            sb.Append("address= '" + ins.Address + "',");
            sb.Append("phone= '" + ins.Phone + "'");
            //sbl.Append("create_date" + cus.Create_date + ";");
            //sbl.Append("last_update" + cus.Last_update + ";");
            sb.Append("WHERE id='" + ins.Id + "';");
            Console.WriteLine(sb.ToString());
            try
            {
                conn.AbrirConexion();
                n = conn.Ejecutar(CommandType.Text, sb.ToString());
                if (n > 0)
                {
                    actualizado = true;

                }
                return actualizado;
            }
            catch (Exception e)
            {

                mn = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, e.Message);
                mn.Run();
                mn.Destroy();
                throw;
            }
            finally
            {
                conn.cerrarConexion();
            }

        }

        public ListStore buscarInstructor(string cadena)
        {
            ListStore lista = new ListStore(typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));//, typeof(string), typeof(string)
            IDataReader lol = null;
            sb.Clear();
            sb.Append("use escuela_manejo;");
            sb.Append("select id_instructor,first_name,last_name,email,id,address,phone from instructor"); //,create_date,last_update
            sb.Append(" where (state <>2) ");
            sb.Append(" AND (id like '%" + cadena + "%' ");
            sb.Append(" OR first_name like '%" + cadena + "%' ");
            sb.Append(" OR last_name like '%" + cadena + "%'); ");
            try
            {
                conn.AbrirConexion();
                lol = conn.Leer(CommandType.Text, sb.ToString());
                while (lol.Read())
                {
                    lista.AppendValues(lol[0].ToString(), lol[1].ToString(),
                    lol[2].ToString(), lol[3].ToString(), lol[4].ToString(), lol[5].ToString(), lol[6].ToString()); //, lol[7].ToString(), lol[8].ToString()
                }
                return lista;
            }
            catch (Exception e)
            {
                mn = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "No hay busqueda");
                mn.Run();
                mn.Destroy();
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;

            }
            finally
            {
                lol.Close();
                conn.cerrarConexion();


            }


        }


#endregion

    }
}
