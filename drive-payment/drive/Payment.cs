using System;
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

        decimal subtotal;
        decimal total;

        public Payment() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            // captamos fecha de factura
            payment.Date = DateTime.Now;
            DateTime pay_date = payment.Date;
            this.lblDate.LabelProp = pay_date.ToString();

            //LLENAMOS LOS COMBOBOX
            FillcomboService();
            FillcomboCLient();

            //POSICIONAMOS EL COMBO EN LA POSICION 0
            CleanCombos();

            string[] titulos = { "Id Curso", "Nombre", "Precio" };
            for (int i = 0; i < titulos.Length; i++)
            {
                trwPayments.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }
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

        protected void onClickBtnPay(object sender, EventArgs e)
        {
            string messageFill = "Llena todos los campos.";
            string messageFulfill = "Pago realizado!";

            // validar campos
            if (string.IsNullOrEmpty(cmbServiceType.ActiveText)) 
            {
                createDialog(messageFill);
            }
            else if (string.IsNullOrEmpty(cmbClient.ActiveText))
            {
                createDialog(messageFill);
            }
            else if (string.IsNullOrEmpty(cmbMethod.ActiveText))
            {
                createDialog(messageFill);
            }
            else
            {
                // todos los campos llenos
                createDialog(messageFulfill);
                this.Destroy();
            }
        }

        protected void onCmbMethodChange(object sender, EventArgs e)
        {
            if (cmbMethod.ActiveText.Equals("Card"))
            {
                drive.CreditCardPayment cardPayment = new drive.CreditCardPayment();
                cardPayment.Show();
            }
            else if (cmbMethod.ActiveText.Equals("Cash"))
            {
                drive.CashPayment cashPayment = new CashPayment();
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
    }
}
