using System;
using Gtk;
using drive.Connection;
using System.Data;
using System.Text;
using System.Collections.Generic;
using drive.Entity;

namespace drive.Data
{
    public class DTPaymentAdmin
    {
        StringBuilder sb = new StringBuilder();
        Connection.Connection con = new Connection.Connection();
        List<PaymentDetails> DetailInfo = new List<PaymentDetails>();
        //ListStore benito = new ListStore(typeof(string), typeof(string), typeof(string)); //es una lista que tiene los valores del treeview para imprimir

        ListStore datos = new ListStore(typeof(string),
               typeof(string), typeof(string), typeof(string));

        public DTPaymentAdmin()
        {
            var conpaymentAd = new drive.Connection.Connection();

            conpaymentAd.AbrirCOnexion();
        }

        public ListStore getColumnsService(String course_service)
        {
            PaymentDetails tpaymentdetails = new PaymentDetails();
            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("SELECT id_course_service, name, price, state FROM course_service WHERE name =" + "'" + course_service + "';");

            try
            {
                con.AbrirCOnexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    datos.AppendValues(idr[0].ToString(), idr[1].ToString(),
                        idr[2].ToString(), idr[3].ToString());

                    //benito.AppendValues(idr[0].ToString(), idr[1].ToString() , idr[2].ToString());

                    tpaymentdetails.Id_course_service = (Int32)idr[0];
                    DetailInfo.Add(tpaymentdetails);

                    //dr.Close();
                }//fin de while


                return datos;
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

        public decimal getServicePrice(string course_service)
        {
            decimal subtotal = 0;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("SELECT price FROM course_service WHERE name =" + "'" + course_service + "';");

            try
            {
                con.AbrirCOnexion();

                idr = con.Leer(CommandType.Text, sb.ToString());
                idr.Read();

                subtotal = idr.GetDecimal(idr.GetOrdinal("price"));

                idr.Close();

                return subtotal;

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

        public bool SavePayment(PaymentEnt pay)
        {
            bool guardado = false; //bandera
            int x = 0; //variable de control

            sb.Clear();
            sb.Append("INSERT INTO payment ");
            sb.Append("(id_costumer,date,total,iva,payment_method,subtotal)");
            sb.Append(" VALUES('" + pay.Id_costumer + "','" + pay.Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" + pay.Total + "','" + pay.Iva + "','" + pay.Payment_method + "','" + pay.Subtotal + "');");

            try
            {
                con.AbrirCOnexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if (x > 0)
                {
                    guardado = true;
                    var ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Info, ButtonsType.Ok, "Se guardo el pago con exito!");
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


        public List<PaymentDetails> GetDetailValues(PaymentEnt paymentEnt)
        {
            //bool guardado = false; //bandera
            int x = 0; //variable de control



            foreach (PaymentDetails tpay in DetailInfo)
            {
                x = 0;
                tpay.Id_payment = getIdPayment(paymentEnt);
                sb.Append("INSERT INTO payment_details ");
                sb.Append("(id_payment,id_course_service)");
                sb.Append(" VALUES('" + tpay.Id_payment + "','" + tpay.Id_course_service + "');");


                Console.WriteLine(tpay.Id_course_service);
                try
                {
                    con.AbrirCOnexion();
                    x = con.Ejecutar(CommandType.Text, sb.ToString());

                    if (x > 0)
                    {
                        //guardado = true;
                        //var ms = new MessageDialog(null, DialogFlags.Modal,
                        //MessageType.Info, ButtonsType.Ok, "Se guardo el pago con exito!");
                        //ms.Run();
                        //ms.Destroy();
                    }

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



            }



            return DetailInfo;
        }


        public int getIdPayment(PaymentEnt paymentEnt)
        {
            int id = 0;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE escuela_manejo;");
            sb.Append("SELECT id_payment FROM payment WHERE id_costumer =" + "'" + paymentEnt.Id_costumer + "' AND date ='" + paymentEnt.Date.ToString("yyyy-MM-dd HH:mm:ss") + "';");

            //Console.WriteLine(paymentEnt.Date.ToString("yyyy-MM-dd HH:mm:ss"));
            try
            {
                con.AbrirCOnexion();

                idr = con.Leer(CommandType.Text, sb.ToString());

                if (idr.Read())
                {
                    id = (Int32)idr[0];
                    Console.WriteLine(id);
                }

                idr.Close();
                return id;

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



      /*  public ListStore returnBenito()
        {
            return benito;


        }*/



    }
}
