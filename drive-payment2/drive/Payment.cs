using System;
using Gtk;
using drive;
using drive.data;

namespace drive
{
    public partial class Payment : Gtk.Window
    {
        public Payment() :
           base(Gtk.WindowType.Toplevel)
        {
            var conpay = new DTpayment();
            this.Build();
        }


        public void cleanEntries()
        {
            // asignar indice 0 = espacio vacio
            cmbServiceType.Active = 0;
            cmbCustomerName.Active = 0;
            cmbMethod.Active = 0;
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
            cleanEntries();
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
    }
}
