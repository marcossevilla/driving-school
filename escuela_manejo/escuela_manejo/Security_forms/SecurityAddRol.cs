using System;
using escuela_manejo.Data;
using escuela_manejo;
using escuela_manejo.business;
using escuela_manejo.Security_data;
using Gtk;

namespace escuela_manejo.Security_forms
{
    public partial class SecurityAddRol : Gtk.Window
    {

        Rol rol = new Rol();
        DTrol dtRol = new DTrol();
        MessageDialog ms = null;

        public SecurityAddRol() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnAgregarRolClicked(object sender, EventArgs e)
        {
            if (txtrol.Text.Equals("") || comborol.Active.Equals(""))
            {
                ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos!!!");
                ms.Run();
                ms.Destroy();
            }
            else
            {
                txtrol.Text = this.txtrol.Text;

                if (dtRol.Saverol(rol))
                {
                    ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Info, ButtonsType.Ok, "Se agrego el rol con exito!!!");
                    ms.Run();
                    ms.Destroy();
                }

                else
                {

                    ms = new MessageDialog(null, DialogFlags.Modal,
                       MessageType.Error, ButtonsType.Ok, "Revise los datos e intente de nuevo");
                    ms.Run();
                    ms.Destroy();
                    this.txtrol.GrabFocus();
                }
            }
        }
    }
}