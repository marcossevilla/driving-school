using System;
using Gtk;
using drive.Entity;
using drive.Data;
using System.Collections.Generic;

namespace drive
{
    public partial class Payment : Gtk.Window
    {
        DTService dtservice = new DTService();
        DTPaymentAdmin dtpayment = new DTPaymentAdmin();
        CourseService cs = new CourseService();

        public Payment() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            //LLENAMOS LOS COMBOBOX
            FillcomboService();
            ///Fillcombostate();

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

        public void CleanCombos()
        {
            //POSICIONAMOS EL COMBO EN LA POSICION 0
            this.cmbServiceType.Active = 0;
            this.cmbCustomerName.Active = 0;
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
            else if (string.IsNullOrEmpty(cmbCustomerName.ActiveText))
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
        }
    }
}
