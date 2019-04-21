using System;
using System.Data;
using MySql.Data;
using Gtk;
using System.Text;
using Escuela_Manejo1.entidades;
using System.Collections.Generic;


namespace Escuela_Manejo1.Datos
{
    public class dtCliente
    {
        Conexion conn = new Conexion();
        MessageDialog msj = null;
        StringBuilder sbl = new StringBuilder();
        #region
        public bool GuardarCliente(Customer cus)
        {
            bool guardado = false;
            int n = 0;
            //string cadenaFecha = Devolverfechainicio();
            sbl.Clear();
            sbl.Append("INSERT INTO customer");
            sbl.Append("(first_name,last_name,email,id,address,state,phone,create_date,last_update)");
            sbl.Append(" VALUES('" + cus.First_name + "','" + cus.Last_name + "','" + cus.Email + "','" + cus.Id + "','" + cus.Address + "','" + 1 + "','" + cus.Phone + "','" + cus.Create_date + "','" + cus.Last_update + "')");
            //+ "," + cus.Create_date + "," + cus.Last_update//

            //'" + cus.Create_date +"'
            //Console.WriteLine("cadena insert " + sbl.ToString());
            try
            {
                conn.AbrirConexion();
                n = conn.Ejecutar(CommandType.Text, sbl.ToString());


              
                if (n > 0)
                {
                    guardado = true;
                }


                return guardado;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error insert " + sbl.ToString());
                msj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, e.Message);
            msj.Run();
            msj.Destroy();
            throw; 

            }
            finally
            {
                conn.cerrarConexion();
            }


        }

        public ListStore listarCliente()
        {                                       //id      first          last           email            address      id                   phone 
            ListStore lista = new ListStore(typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));
            IDataReader rd = null;
            sbl.Clear();
            sbl.Append("select id_customer,first_name,last_name,email,address,id,phone,create_date from customer"); //,create_date,last_update
            try
            {
                conn.AbrirConexion();
                rd = conn.Leer(CommandType.Text, sbl.ToString());
                while (rd.Read())
                {                           //id          first
                    lista.AppendValues(rd[0].ToString(), rd[1].ToString(),
                    rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString()); //, rd[7].ToString(), rd[8].ToString()
                    //last       email          addres                   id        phone          
                }
                return lista;
            }
            catch (Exception e)
            {
                msj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, e.Message);
                msj.Run();
                msj.Destroy();
                throw;
            }
            finally
            {
                rd.Close();
                conn.cerrarConexion();


            }
        }
        //return lista;

        public bool existeCliente(Customer cus)
        {
            bool existe = false;
            IDataReader r = null;
            sbl.Clear();
            sbl.Append("use escuela_manejo;");
            sbl.Append("select id from customer where id = " + "'" + cus.Id + "';");
            try
            {
                conn.AbrirConexion();
                r = conn.Leer(CommandType.Text, sbl.ToString());
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
        /*

        public bool ExisteCliente(Customer cus)
        {
            bool existe = false;
            IDataReader r = null;
            sbl.Clear();
            sbl.Append("use escuela_manejo");
            sbl.Append("select * from customer WHERE id= '" + cus.Id + "';");
            try
            {
                conn.AbrirConexion();
                r = conn.Leer(CommandType.Text, sbl.ToString());
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
        }
        */

        public Int32 Eliminarcliente(Customer cus)
        {
            int eliminado;
            sbl.Clear();
            sbl.Append("use escuela_manejo;");
            sbl.Append("update customer set state = '2' WHERE id= '"+cus.Id+"';");
            Console.WriteLine(sbl.ToString());
            //update customer set state= '2' where id= 'id';
            try
            {
                conn.AbrirConexion();
                eliminado = conn.Ejecutar(CommandType.Text, sbl.ToString());
                return eliminado;
            }
            catch (Exception e)
            {
                msj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, e.Message);
                msj.Run();
                msj.Destroy();
                throw;
            }
        }

        public bool actualizar(Customer cus)
        {
            bool actualizado = false;
            int n = 0;
            sbl.Clear();
            sbl.Append("use escuela_manejo;");
            sbl.Append("update customer set first_name= '"+cus.First_name+"',");
            sbl.Append("last_name= '"+cus.Last_name+"',");
            sbl.Append("email= '" + cus.Email + "',");
            sbl.Append("address= '" + cus.Address + "',");
            sbl.Append("phone= '" + cus.Phone + "',");
            //sbl.Append("create_date= '" + cus.Create_date + "'");
            sbl.Append("last_update='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'");
            sbl.Append("WHERE id='"+cus.Id+"';");
            Console.WriteLine(sbl.ToString());
            try
            {
                conn.AbrirConexion();
                n = conn.Ejecutar(CommandType.Text,sbl.ToString());
                if(n>0)
                {
                    actualizado = true;
                
                }
                return actualizado;
            }
            catch (Exception e) {
            
                msj= new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, e.Message);
                msj.Run();
                msj.Destroy();
                throw;
            }
            finally {
                conn.cerrarConexion();
            }

        }


        public ListStore buscarCliente(string cadena)
        {
            ListStore lista = new ListStore(typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));//, typeof(string), typeof(string)
            IDataReader lol = null;
            sbl.Clear();
            sbl.Append("use escuela_manejo;");
            sbl.Append("select id_customer,first_name,last_name,email,id,address,phone,create_date from customer"); //,create_date,last_update
            sbl.Append(" where"); //(state <> 2)
            sbl.Append(" (id like '%" + cadena + "%' ");
            sbl.Append(" OR first_name like '%" + cadena + "%' ");
            sbl.Append(" OR last_name like '%" + cadena + "%'); ");
            try {
                conn.AbrirConexion();
                lol = conn.Leer(CommandType.Text, sbl.ToString());
                while (lol.Read())
                {
                    lista.AppendValues(lol[0].ToString(), lol[1].ToString(),
                    lol[2].ToString(), lol[3].ToString(), lol[4].ToString(), lol[5].ToString(), lol[6].ToString(),lol[7].ToString()); //, lol[7].ToString(), lol[8].ToString()
                }
                return lista;
            }catch (Exception e)
            {
                msj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "No hay busqueda");
                msj.Run();
                msj.Destroy();
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;

            }
            finally {
                lol.Close();
                conn.cerrarConexion();
             
              
            }


        }


        public List<Escuela_Manejo1.entidades.Customer> cbxCus()
        {
            List<Escuela_Manejo1.entidades.Customer> listCourse = new List<Escuela_Manejo1.entidades.Customer>();
            IDataReader idr = null;
            sbl.Clear();
            sbl.Append("USE escuela_manejo;");
            sbl.Append("SELECT id_customer, first_name, last_name FROM customer;");

            try
            {
                conn.AbrirConexion();
                idr = conn.Leer(CommandType.Text, sbl.ToString());
                while (idr.Read())
                {
                    entidades.Customer tins = new entidades.Customer()
                    //Tbl_usuarios tus = new Tbl_usuarios()
                    {
                        Id_customer = (Int32)idr["id_customer"],
                        First_name = idr["first_name"].ToString(),
                        Last_name = idr["last_name"].ToString(),
                    };
                    listCourse.Add(tins);

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
                conn.cerrarConexion();
            }
        }





        #endregion



        public dtCliente()
        {
        }



    }
}




   
