using System;
using Gtk;
using Seguridad.Datos;
using Seguridad.entidades;

namespace Seguridad
{
    public partial class FrmUsuarios : Gtk.Window
    {
        dtUsuario dtus = new dtUsuario();

        public FrmUsuarios() :base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            tvwUsuario1.Model = dtus.listar_usuarios();
            String [] titulos = { "id Usuario", "Usuario", "Nombres", "Apellidos", "Email" };
             for(int i = 0; i<titulos.Length; i++)
            {
                tvwUsuario1.AppendColumn(titulos[i],new CellRendererText(),"text",i);
            }
            this.txtNombre.GrabFocus();
        }

        protected void onBtnGuardarClicked(object sender, EventArgs e)
        {
            Tbl_user tus = new Tbl_user();
            tus.Nombres = this.txtNombre.Text;
            tus.Apellidos = this.txtApellidos.Text;
            tus.User = this.txtUsuario.Text;
            tus.Email = this.txtEmail.Text;
             
            if (this.txtClave.Text.Trim().Equals(this.txtRepitaClave.Text.Trim()))
            {
                tus.Pwd = this.txtClave.Text;

            }
            else
            {
                   MessageDialog ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Las claves no coinciden...");
                   ms.Run();
                   ms.Destroy();
            }

          

            if (dtus.GuardarUsuario(tus))
            {
                MessageDialog ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Se guardo el usuario con exito...");
                ms.Run();
                ms.Destroy();
                LimpiarCuadros_de_texto();
                tvwUsuario1.Model = dtus.listar_usuarios();
            }
            else
            {
                MessageDialog ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Ocurrio un error..");
                ms.Run();
                ms.Destroy();
            }


        }

        public void LimpiarCuadros_de_texto()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtRepitaClave.Text = "";
            txtEmail.Text = " ";
        }

        protected void onELiminarCLicked(object sender, EventArgs e)
        {

        }

        protected void onCancelarClicked(object sender, EventArgs e)
        {
            LimpiarCuadros_de_texto();
        }

        
    }
}
