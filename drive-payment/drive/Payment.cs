using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Gtk;
using drive.Entity;
using drive.Data;
using System.Collections.Generic;
using Escuela_Manejo1;
using Escuela_Manejo1.entidades;
using Escuela_Manejo1.Datos;


namespace drive
{
    public partial class Payment : Gtk.Window
    {
        DTService dtservice = new DTService();
        DTPaymentAdmin dtpayment = new DTPaymentAdmin();
        dtCliente dtclient = new dtCliente();
        CourseService cs = new CourseService();
        PaymentEnt payment = new PaymentEnt();

        /*PrintDocument pd = new PrintDocument();
        PrintPreviewDialog dg = new PrintPreviewDialog();*/
        int j = 0;
        /*string texto = " "; // la peor forma de hacer esto pero quiero dormir */

        PrintDocument reporteFactura = new PrintDocument();
        PrintPreviewDialog vista = new PrintPreviewDialog();
        String cadenaImpresion = "";


        decimal subtotal;
        decimal total;

        public Payment() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            // captamos fecha de factura
            payment.Date = DateTime.Now;
            DateTime pay_date = payment.Date;
            this.lblDate.LabelProp = pay_date.ToString("dddd, dd MMMM yyyy");

            //LLENAMOS LOS COMBOBOX
            FillcomboService();
            FillcomboCLient();
            this.cmbMethod.Active = 0;

            //POSICIONAMOS EL COMBO EN LA POSICION 0
            CleanCombos();

            string[] titulos = { "ID Servicio", "Nombre", "Precio" };
            for (int i = 0; i < titulos.Length; i++)
            {
                trwPayments.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }


            /*  var destroy = cashPayment.Destroy();


            if (destroy == 1)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }

            */


        }

        public void FillcomboService()
        { 

            List<CourseService> listCourse = new List<CourseService>();
            listCourse = dtservice.cmbServiceType();

            cmbServiceType.InsertText(0, "Seleccione...");

            foreach (CourseService tcourseservice in listCourse)
            {
                cmbServiceType.InsertText(tcourseservice.Id_course_service, tcourseservice.Name);
            }

        }

        public void FillcomboCLient()
        {

            List<Customer> listClient = new List<Customer>();
            listClient = dtclient.cbxCus();

            cmbClient.InsertText(0, "Seleccione...");

            foreach (Customer tcustomer in listClient)
            {
                string full_name = tcustomer.First_name + " " + tcustomer.Last_name;
                cmbClient.InsertText(tcustomer.Id_customer, full_name);
            }

        }

        public void CleanCombos()
        {
            //POSICIONAMOS EL COMBO EN LA POSICION 0
            this.cmbServiceType.Active = 0;
            this.cmbClient.Active = 0;
            this.cmbMethod.Active = 0;
        }

        public MessageDialog createDialog(string message)
        {
            MessageDialog ms = null;
            ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, message);
            ms.Run();
            ms.Destroy();
            return ms;
        }

        protected void onClickBtnClean(object sender, EventArgs e)
        {
            CleanCombos();
        }

        public void onClickBtnPay(object sender, EventArgs e)
        {
            string messageFill = "Llena todos los campos.";

            // validar campos
            if (cmbServiceType.ActiveText == "Seleccione...") 
            {
                createDialog(messageFill);
            }
            else if (cmbClient.ActiveText == "Seleccione...")
            {
                createDialog(messageFill);
            }
            else if (cmbMethod.ActiveText == "Seleccione...")
            {
                createDialog(messageFill);
            }
            else
            {   
                string fullname = this.cmbClient.ActiveText;
                string[] names = fullname.Split(' ');

                payment.Id_costumer = dtclient.getIdClientFull(names);
                payment.Iva = 15;
                payment.Payment_method = this.cmbMethod.ActiveText;
                payment.Subtotal = float.Parse(this.lblSubtotalValue.LabelProp);
                payment.Total = float.Parse(this.lblTotalValue.LabelProp);


                //this.pd.PrintPage += this.Impresion;
                //pd.Print();

                //dg.Document = pd;
                //dg.ShowDialog();

               
                dtpayment.SavePayment(payment);
                dtpayment.GetDetailValues(payment);

                //this.Destroy();


                this.reporteFactura.PrintPage += this.Impresion;
                this.vista.Name = "Vista previa a la impresion";
                this.vista.ClientSize = new System.Drawing.Size(720, 480);
                this.vista.Document = reporteFactura;
                this.vista.ShowDialog();



                try
                {

                    this.reporteFactura.Print();

                }
                catch (Exception ex)
                {
                    MessageDialog ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "No existe una impresora conectada" );
                    ms.Run();
                    ms.Destroy();
                }


            }
        }

        public void onCmbMethodChange(object sender, EventArgs e)
        {
            if (cmbMethod.ActiveText.Equals("Card"))
            {
                drive.CreditCardPayment cardPayment = new drive.CreditCardPayment();
                cardPayment.Show();
            }
            else if (cmbMethod.ActiveText.Equals("Cash"))
            {
                drive.CashPayment cashPayment = new drive.CashPayment(float.Parse(lblTotalValue.LabelProp));
                cashPayment.total = float.Parse(lblTotalValue.LabelProp);
                Console.WriteLine(cashPayment.total);

                cashPayment.Show();

            }
        }

        protected void onClickBtnPayCourseService(object sender, EventArgs e)
        {
            this.trwPayments.Model = dtpayment.getColumnsService(this.cmbServiceType.ActiveText);

            var self_subtotal = dtpayment.getServicePrice(this.cmbServiceType.ActiveText);

            subtotal = subtotal + self_subtotal;
            total = subtotal * 1.15m;

            // docs hechizos
            // this.lblServiceType.LabelProp = global::Mono.Unix.Catalog.GetString("Tipo de Servicio");
            this.lblSubtotalValue.LabelProp = subtotal.ToString();
            this.lblTotalValue.LabelProp = total.ToString();
        }

        protected void onClickBtnAddCustomer(object sender, EventArgs e)
        {
            Escuela_Manejo1.Frm_Clientes client = new Frm_Clientes();
            client.Show();
        }

       public void Impresion(object sender , PrintPageEventArgs ev)
        {
            cadenaImpresion = "";

            this.cadenaImpresion += "Escuela de Manejo Luisa Mercado" + "\n\nFactura #" + dtpayment.getIdPayment(this.payment) + "\n\n" +
                "Fecha: " + DateTime.Now.ToString("dddd, dd MMMM yyyy") +
                "\n\nCliente: " + this.cmbClient.ActiveText + "\n\n" +
                "----------------------------------------------------------------------\n" +
                "     ID    Servicio    Precio\n\n" +
                "----------------------------------------------------------------------\n";


            /*ev.Graphics.DrawString(cadenaImpresion, new Font("Arial", 19), Brushes.Black, 20, 0);*/

            var datos = dtpayment.getColumnsService(this.cmbServiceType.ActiveText);

            TreeIter iter1;

            if(datos.GetIterFirst(out iter1))
            {
                while(datos.IterNext(ref iter1))
                {

                    for(j = 0; j< trwPayments.Columns.Length; j++)
                    {
                        TreeIter iter2;
                        if(datos.GetIterFirst(out iter2))
                        {

                            cadenaImpresion += "      " + datos.GetValue(iter1, j).ToString();
                            //Console.WriteLine("pene");

                        }
                        if(j == trwPayments.Columns.Length - 1)
                        {
                            cadenaImpresion += "\n";

                        }
                    }
                }

                this.cadenaImpresion += "----------------------------------------------------------------------" +
                    "\n\n\n\nSubtotal        " + this.lblSubtotalValue.LabelProp +
                    "\n\nIVA                15%" +
                    "\n\nTotal              " + this.lblTotalValue.LabelProp + "\n\n";

                ev.Graphics.DrawString(cadenaImpresion,new Font("Arial",19), Brushes.Black, 20,0);

            }
            //if(datos.IterNext) */



        }



    }
}
/*if (cashPayment.Visible)
                {
                    this.Visible = false;
                }
                else
                {
                    this.Visible = true;
                }

*/                