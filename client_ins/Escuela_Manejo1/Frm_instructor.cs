using System;
using Escuela_Manejo1.entidades;
using Escuela_Manejo1.Datos;
using Escuela_Manejo1.Otros;
using Gtk;
namespace Escuela_Manejo1
{
    public partial class Frm_instructor : Gtk.Window
    {
        Instructor ins = new Instructor();
        dtInstructor dti = new dtInstructor();
        mgInstructor mgi = new mgInstructor();
        MessageDialog mnsj = null;
        public Frm_instructor() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            trwInstructor.Model = dti.listarInstructor();
            string[] titulos = {"id_instructor", "Nombre", "Apellido", "correo", "direccion", "id", "telefono", "fecha inicial", "fecha actualizada" };
            for (int i = 0; i < titulos.Length; i++)
            {
                trwInstructor.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }
        }


        private void limpiarcosas()
        {
            txtidIn.Text = "";
            txtNombreI.Text = "";
            txtApellidoI.Text = "";
            txtBuscarIns.Text = "";
            txtTelefonoins.Text = "";
            txtDireccionIn.Text = "";

        }

        protected void OnBtnGuardarinClicked(object sender, EventArgs e)
        {
            if (txtidIn.Text.Equals("") || txtNombreI.Text.Equals("") || txtApellidoI.Text.Equals("") || txtcorreoIn.Text.Equals("") || txtDireccionIn.Equals("") || txtTelefonoins.Text.Equals(""))
            {

                mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos");
                mnsj.Run();
                mnsj.Destroy();
            }
            else
            {


                ins.First_name = this.txtNombreI.Text;
                ins.Last_name = this.txtApellidoI.Text;
                ins.Email = this.txtcorreoIn.Text;
                ins.Phone = this.txtTelefonoins.Text;
                ins.Id = this.txtidIn.Text;
                ins.Address = this.txtDireccionIn.Text;

                //cus.Create_date = Devolverfechainicio();
                //cus.Last_update = this.devolverfechaactualizada();
                if (mgi.Mguardarinstructor(ins))
                {
                    mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Se guardo el Instructor");
                    mnsj.Run();
                    mnsj.Destroy();

                    trwInstructor.Model = dti.listarInstructor();
                }
                else
                {

                    mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "No se guardo");
                    mnsj.Run();
                    mnsj.Destroy();
                    //this.txtidc.GrabFocus();
                }

            }



        }

        protected void OnBtnEliminarinClicked(object sender, EventArgs e)
        {
            int eliminado = 0;
            eliminado = dti.EliminarInstructor(ins);
            if (eliminado != 0)
            {
                mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "instructor eliminado con exito");
                mnsj.Run();
                mnsj.Destroy();
                this.limpiarcosas();
                trwInstructor.Model = dti.listarInstructor();

            }
            else
            {
                mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Seleccione un instructor");
                mnsj.Run();
                mnsj.Destroy();

            }

        }

        protected void OnTrwInstructorCursorChanged(object sender, EventArgs e)
        {
            TreeSelection seleccions = (sender as TreeView).Selection;
            TreeIter iter;
            TreeModel modelo;
            if (seleccions.GetSelected(out modelo, out iter))
            {
                //cus.Id = modelo.GetValue(iter, 0).ToString();
                ins.Id = modelo.GetValue(iter, 5).ToString();
                this.txtNombreI.Text = modelo.GetValue(iter, 1).ToString();
                this.txtApellidoI.Text = modelo.GetValue(iter, 2).ToString();
                this.txtcorreoIn.Text = modelo.GetValue(iter, 3).ToString();
                this.txtTelefonoins.Text = modelo.GetValue(iter, 4).ToString();
                this.txtidIn.Text = modelo.GetValue(iter, 5).ToString();
                this.txtDireccionIn.Text = modelo.GetValue(iter, 6).ToString();

            }
        }

        protected void OnBtnEDitarinClicked(object sender, EventArgs e)
        {
            if (txtidIn.Text.Equals("") || txtNombreI.Text.Equals("") || txtApellidoI.Text.Equals("") || txtcorreoIn.Text.Equals("") || txtDireccionIn.Equals("") || txtTelefonoins.Text.Equals(""))
            {

                mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos");
                mnsj.Run();
                mnsj.Destroy();
            }
            else
            {


                ins.First_name = this.txtNombreI.Text;
                ins.Last_name = this.txtApellidoI.Text;
                ins.Email = this.txtcorreoIn.Text;
                ins.Phone = this.txtTelefonoins.Text;
                ins.Id = this.txtidIn.Text;
                ins.Address = this.txtDireccionIn.Text;

                ///cus.Create_date = Devolverfechainicio();
                //cus.Last_update = this.devolverfechaactualizada();
                if (dti.actualizar(ins))
                {
                    mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Se actualizo el instructor");
                    mnsj.Run();
                    mnsj.Destroy();

                    trwInstructor.Model = dti.listarInstructor();
                }
                else
                {

                    mnsj = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "No se guardo");
                    mnsj.Run();
                    mnsj.Destroy();
                    //this.txtidc.GrabFocus();
                }

            }



        }

        protected void OnBtnBuscarinClicked(object sender, EventArgs e)
        {
            String busqueda = "";
            busqueda = this.txtBuscarIns.Text.Trim();
            this.trwInstructor.Model = dti.buscarInstructor(busqueda);

        }

        protected void OnBtnNuevoInsClicked(object sender, EventArgs e)
        {
            limpiarcosas();

        }
    }

}
