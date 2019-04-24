using System;
using Escuela_Manejo1.entidades;
using Escuela_Manejo1.Datos;
using Escuela_Manejo1.Negocio;
using System.Globalization;
using Gtk;
namespace Escuela_Manejo1
{
    public partial class Frm_Clientes : Gtk.Window
    {
        Customer cus = new Customer();
        dtCliente dcl = new dtCliente();
        mgCustomer mgs = new mgCustomer();
        MessageDialog mnsj = null;
        public Frm_Clientes() :
                base(Gtk.WindowType.Toplevel)
        {

            this.Build();
            trwtabla.Model = dcl.listarCliente();
            string[] titulos = { "ID Cliente", "Nombre", "Apellido", "Correo", "Dirección", "Id", "Teléfono", "Fecha inicial", "fecha actualizada" };
            for (int i = 0; i < titulos.Length; i++)
            {
                trwtabla.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }

        }

        public void limpiarCosas()
        {
            this.txtidc.Text = "";
            this.txtnombrec.Text = "";
            this.txtapellidoc.Text = "";
            this.txtbuscar.Text = "";
            this.txtcorreoc.Text = "";
            this.txttelefonoc.Text = "";
            txtdireccionc.Text = "";

        }

        //public DateTime Devolverfechainicio()
        //{

            //DateTime tm;
            //string hora;
            //string minuto;
            //string dateString = calend1.GetDate().ToString("yyyy/MM/dd");

            //hora = this.cmbHrI.ActiveText;
            //ToString("MM/dd/yyyy HH':'mm':'ss");
            //minuto = this.cmbMinI.ActiveText;
            //string concatenar = dateString+" "+hora+":"+minuto+":"+"00";
            //DateTime.TryParse(concatenar,out tm);
            //tm =  DateTime.ParseExact(concatenar, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            //Console.WriteLine("fecha"+ tm);
            //Console.WriteLine("fecha cadena " + concatenar);
            // tm =  DateTime.ParseExact(concatenar, "yyyy-MM-dd HH:mm HH", CultureInfo.InvariantCulture);

            //tm=DateTime.ParseExact(concatenar, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
            //tm = DateTime.ParseExact(concatenar, "yyyy/MM/dd HH:mm:ss", null);
            //Console.WriteLine("fecha " + tm);
            //return tm;




        //}




        /*
        private DateTime devolverfechaactualizada()
        {
            DateTime tm;
            string hora;
            string minuto;
            string dateString = calend2.GetDate().ToString("MM/dd/yyyy");

            hora = cmbhrF.ActiveText;

            minuto = cmbMinF.ActiveText;
            string concatenar = dateString+" "+hora+":"+minuto;
            tm = DateTime.Parse(concatenar);
            //return tm;


        }
        */

        protected void OnBtnNuevoClicked(object sender, EventArgs e)
        {
            limpiarCosas();
        }

        protected void OnBtnGuardarClicked(object sender, EventArgs e)
        {
            if (txtidc.Text.Equals("") || txtnombrec.Text.Equals("") || txtapellidoc.Text.Equals("") || txtcorreoc.Text.Equals("") || txtdireccionc.Text.Equals("") || txttelefonoc.Text.Equals("") )
            {

                mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos");
                mnsj.Run();
                mnsj.Destroy();
            }
            else
            {

                cus.Id = this.txtidc.Text;
                cus.First_name = this.txtnombrec.Text;
                cus.Last_name = this.txtapellidoc.Text;
                cus.Email = this.txtcorreoc.Text;
                cus.Address = this.txtdireccionc.Text;
                cus.Phone = this.txttelefonoc.Text;
                cus.Create_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                cus.Last_update = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (mgs.Mguardarcliente(cus))
                {
                    mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Se guardó el usuario");
                    mnsj.Run();
                    mnsj.Destroy();
                    limpiarCosas();
                    trwtabla.Model = dcl.listarCliente();
                }
                else
                {

                    mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "No se guardó");
                    mnsj.Run();
                    mnsj.Destroy();
                    //this.txtidc.GrabFocus();
                }

            }

        }

        protected void OnBtnEliminarClicked(object sender, EventArgs e)
        {
            int eliminado = 0;
            eliminado = dcl.Eliminarcliente(cus);
            if(eliminado!=0)
            {
                mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Usuario eliminado con éxito.");
                mnsj.Run();
                mnsj.Destroy();
                limpiarCosas();
                trwtabla.Model = dcl.listarCliente();

            }
            else {
                mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Seleccione un usuario.");
                mnsj.Run();
                mnsj.Destroy();

            }

        }

        protected void OnTrwtablaCursorChanged(object sender, EventArgs e)
        {
            TreeSelection seleccions = (sender as TreeView).Selection;
            TreeIter iter;
            TreeModel modelo;
            if(seleccions.GetSelected(out modelo, out iter))
            {
                //cus.Id = modelo.GetValue(iter, 0).ToString();
                cus.Id = modelo.GetValue(iter, 5).ToString();
                this.txtnombrec.Text = modelo.GetValue(iter, 1).ToString();
                this.txtapellidoc.Text = modelo.GetValue(iter, 2).ToString();
                this.txtcorreoc.Text = modelo.GetValue(iter, 3).ToString();
                this.txtdireccionc.Text = modelo.GetValue(iter, 4).ToString();
                this.txtidc.Text= modelo.GetValue(iter, 5).ToString();
                this.txttelefonoc.Text = modelo.GetValue(iter, 6).ToString();

            }

        }

        protected void OnBtnEditarClicked(object sender, EventArgs e)
        {
            if ( txtnombrec.Text.Equals("") || txtapellidoc.Text.Equals("") || txtcorreoc.Text.Equals("") || txtdireccionc.Text.Equals("") || txttelefonoc.Text.Equals(""))
            {

                mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos.");
                mnsj.Run();
                mnsj.Destroy();
            }
            else {



                cus.First_name = this.txtnombrec.Text;
                cus.Last_name = this.txtapellidoc.Text;
                cus.Email = this.txtcorreoc.Text;
                cus.Address = this.txtdireccionc.Text;
                cus.Phone = this.txttelefonoc.Text;
                //cus.Create_date = Devolverfechainicio();
                //cus.Create_date = tm;
                //cus.Last_update = tml;
                cus.Last_update = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                cus.State = 1;
                if (dcl.actualizar(cus))
                {
                    mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Se actualizó cliente.");
                    mnsj.Run();
                    mnsj.Destroy();
                    limpiarCosas();
                    trwtabla.Model = dcl.listarCliente();
                }
                else
                {
                    mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "No se actualizó.");
                    mnsj.Run();
                    mnsj.Destroy();
                    //this.txtidc.GrabFocus();
                }




            }



        }

        protected void OnBtnBuscarClicked(object sender, EventArgs e)
        {
            String busqueda = "";
            busqueda = this.txtbuscar.Text.Trim();
            this.trwtabla.Model = dcl.buscarCliente(busqueda);
        }


    }


}
