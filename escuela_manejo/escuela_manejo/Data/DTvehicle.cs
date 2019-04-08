using System;
using Gtk;
using System.Text;
using System.Data;
using System.Collections.Generic;
using escuela_manejo;
namespace escuela_manejo.Data
{
    public class DTvehicle
    {
        StringBuilder sb = new StringBuilder();
        Connection.Connection con = new Connection.Connection();
        MessageDialog ms = null;

        public DTvehicle()
        {
        }

        public ListStore ListCourse()
        {
            ListStore data = new ListStore(typeof(string),
                typeof(string), typeof(string), typeof(string), typeof(string),typeof(string), typeof(string));
            IDataReader dr = null;
            sb.Clear();
            sb.Append("SELECT id_vehicle,id_category,model,brand,plate,color,state FROM vehicle");
            try
            {
                con.AbrirCOnexion();
                dr = con.Leer(CommandType.Text, sb.ToString());
                while (dr.Read())
                {
                    data.AppendValues(dr[0].ToString(), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
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


        public bool SaveVehicle(escuela_manejo.Vehicle tvehi)
        {
            bool guardado = false; //bandera
            int x = 0; //variable de control
            sb.Clear();
            sb.Append("INSERT INTO vehicle ");
            sb.Append("(id_category,model,brand,plate,color,state)");
            sb.Append(" VALUES('" + tvehi.Id_category + "','" + tvehi.Model + "','" + tvehi.Brand + "','"+ tvehi.Plate + "','" + tvehi.Color + "','" + tvehi.State + "')");
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



        public Int32 DeleteVehicle(escuela_manejo.Vehicle dvehi)
        {
            int delete;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("Delete from vehicle WHERE id_vehicle=" + dvehi.Id_vehicle + ";");

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


        public ListStore SearchVehi(String cadena)
        {
            ListStore datos = new ListStore(typeof(string),
                typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));
            IDataReader dr = null;
            sb.Clear();
            sb.Append(" USE escuela_manejo;");
            sb.Append(" SELECT id_vehicle,id_category,model,brand,plate,color,state FROM vehicle ");
            //sb.Append(" WHERE (estado <>3) ");
            sb.Append(" WHERE (id_category like '%" + cadena + "%' ");
            sb.Append(" OR model like '%" + cadena + "%' ");
            sb.Append(" OR brand like '%" + cadena + "%' ");
            sb.Append(" OR plate like '%" + cadena + "%' ");
            sb.Append(" OR color like '%" + cadena + "%' ");
            sb.Append(" OR state like '%" + cadena + "%'); ");
            try
            {
                con.AbrirCOnexion();
                dr = con.Leer(CommandType.Text, sb.ToString());
                while (dr.Read())
                {
                    datos.AppendValues(dr[0].ToString(), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                    //dr.Close();
                }//fin de while
                return datos;
            }
            catch (Exception e)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Error: " + e.StackTrace);
                throw;
            }
            finally
            {
                dr.Close();
                con.CerrarConexion();
            }
        }//fin del metodo

        public List<escuela_manejo.Vehicle> cbxState()
        {
            List<escuela_manejo.Vehicle> listvehi = new List<escuela_manejo.Vehicle>();
            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("SELECT id_vehicle,plate FROM vehicle;");

            try
            {
                con.AbrirCOnexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    escuela_manejo.Vehicle tvehi = new escuela_manejo.
                    Vehicle()
                    //Tbl_usuarios tus = new Tbl_usuarios()
                    {
                        Id_vehicle = (Int32)idr["id_vehicle"],
                        Plate = idr["plate"].ToString(),

                    };
                    listvehi.Add(tvehi);

                }
                idr.Close();
                return listvehi;

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







    }
}
