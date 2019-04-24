using System;
using Gtk;

namespace drive
{
    public partial class CashPayment: Gtk.Window
    {
        public float total;
        public float cambio;
        public float pago;

        public CashPayment(float total) :
                base(Gtk.WindowType.Toplevel)
        {

            this.Build();
            this.lblTotalValue.LabelProp = total.ToString();
        }

        protected void onClickBtnPayCash(object sender, EventArgs e)
        {
            MessageDialog ms = null;


            if (string.IsNullOrEmpty(entAmount.Text))
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Llena el campo.");
                ms.Run();
                ms.Destroy();
            }
            else if (float.Parse(this.entAmount.Text) < total)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "La cantidad depositada no es suficiente.");
                ms.Run();
                ms.Destroy();
            }
            else
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Datos guardados.");
                ms.Run();
                ms.Destroy();
                this.Destroy();
            }
        }

        protected void onClickBtnAddMoney(object sender, EventArgs e)
        {
            try
            {
                var deposit = float.Parse(this.entAmount.Text);
                var change = deposit - total;
                this.lblChangeValue.LabelProp = change.ToString();
            }
            catch 
            {
                var ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "El valor debe ser un número.");
                ms.Run();
                ms.Destroy();
                this.Destroy();
            }

        }


       /* public int onDestroy()
        {
            int destroy = 1;


            return destroy;
            
        }*/



    }
}

