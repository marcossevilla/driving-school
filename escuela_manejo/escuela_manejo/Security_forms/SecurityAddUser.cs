using System;
using Gtk;
using escuela_manejo.Security_business;
using escuela_manejo.Security_data;
namespace escuela_manejo.Security_forms
{
    public partial class SecurityAddUser : Gtk.Window
    {
        User tus = new User();
        buser buser = new buser();
        DTuser duser = new DTuser();

        public SecurityAddUser() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }


        protected void OnBtnSaveClicked(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("") || txtname.Text.Equals("") || txtemail.Text.Equals("") || txtphone.Text.Equals("") || txtlastname.Text.Equals("") || txtpassword.Text.Equals("") || txtusername.Text.Equals("")) 
            {
                var ms = new MessageDialog(null, DialogFlags.Modal,
                         MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos!!!");
                ms.Run();
                ms.Destroy();
            }
            else
            {
                tus.Username = this.txtusername.Text;
                tus.Pwd = this.txtpassword.Text;
                tus.First_name = this.txtname.Text;
                tus.Last_name = this.txtlastname.Text;
                tus.Email = this.txtemail.Text;
                tus.Phone = this.txtphone.Text;

                if (buser.BSsaveuser(tus))
                {
                    if (duser.SaveUser(tus))
                    {
                        var ms = new MessageDialog(null, DialogFlags.Modal,
                            MessageType.Info, ButtonsType.Ok, "Se guardo el vehiculo con exito!!!");
                        ms.Run();
                        ms.Destroy();
                        CleanEntries();
                    }
                    else
                    {

                        var ms = new MessageDialog(null, DialogFlags.Modal,
                            MessageType.Error, ButtonsType.Ok, "Revise los datos e intente nuevamente!!!");
                        ms.Run();
                        ms.Destroy();
                        this.txtusername.GrabFocus();
                    }
                }

                else
                {

                    var ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, "Revise los datos e intente nuevamente!!!");
                    ms.Run();
                    ms.Destroy();
                    this.txtusername.GrabFocus();
                }
            }

        }



        public void CleanEntries()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtname.Text = "";
            txtlastname.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtid.Text = "";

        }//fin del metodo


    }
}
