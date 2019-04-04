using System;
using Gtk;

namespace drive
{
    public partial class CreditCardPayment : Gtk.Window
    {
        private string dateString = "null";

        public CreditCardPayment() :
                base(Gtk.WindowType.Toplevel) => this.Build();

        public void cleanEntries()
        {
            // asignar indice 0 = espacio vacio
            entCardNum.Text = "";
            entNameCard.Text = "";
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

        protected void onClickBtnOK(object sender, EventArgs e)
        {
            string messageFill = "Llena todos los campos.";
            string messageFulfill = "Tarjeta registrada!";

            if (entCardNum.Text.Equals(string.Empty))
            {
                createDialog(messageFill);
            }
            else if (entNameCard.Text.Equals(string.Empty))
            {
                createDialog(messageFill);
            }
            else if (dateString.Equals(string.Empty))
            {
                createDialog(messageFill);
            }
            else
            {
                createDialog(messageFulfill);
                this.Destroy();
            }
        }

        protected void onDaySelected(object sender, EventArgs e)
        {
            dateString = calExpDate.GetDate().ToString("MM/yyyy");
            createDialog(dateString);
        }
    }
}
