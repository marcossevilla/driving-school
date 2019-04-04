using System;
using Gtk;

namespace drive
{
    public partial class CashPayment : Gtk.Window
    {
        public CashPayment() :
                base(Gtk.WindowType.Toplevel) => this.Build();

        protected void onClickBtnPayCash(object sender, EventArgs e)
        {
            MessageDialog ms = null;

            if (string.IsNullOrEmpty(entAmount.Text))
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Llena el campo.");
                ms.Run();
                ms.Destroy();
            }
            else
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Datos guardados!");
                ms.Run();
                ms.Destroy();
                this.Destroy();
            }
        }
    }
}
