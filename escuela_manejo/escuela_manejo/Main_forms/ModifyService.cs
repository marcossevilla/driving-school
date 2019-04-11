using System;
using Gtk;
using escuela_manejo.Data;
using escuela_manejo.business;
using System.Text;

namespace escuela_manejo.Main_forms
{
    public partial class ModifyService : Gtk.Window
    {
        DTservice dtservices = new DTservice();
        BSservice bservice = new BSservice();
        CourseService tservice = new CourseService();
        StringBuilder sb = new StringBuilder();

        public ModifyService() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            TrwModifyService.Model = dtservices.ListService();
            string[] titulos = { "Id Servicio", "Nombre", "Precio" , "Estado" };
            for (int i = 0; i < titulos.Length; i++)
            {
                TrwModifyService.AppendColumn(titulos[i], new CellRendererText(), "text", i);

            }

          
                    }


        protected void OnTvwUsuariosCursorChanged(object sender, EventArgs e)
        {


            TreeSelection seleccion = (sender as TreeView).Selection;
            TreeIter iter;
            TreeModel model;
            if (seleccion.GetSelected(out model, out iter))
            {
                //tservice.Id_course_service = Convert.ToInt32(model.GetValue(iter, 0).ToString());
                this.txtname.Text = model.GetValue(iter, 1).ToString();
                this.txtprice.Text = model.GetValue(iter, 2).ToString();
                this.txtstate.Text = model.GetValue(iter, 3).ToString();
                //this.txtnombres.Text = model.GetValue(iter, 2).ToString();
                //this.txtapellidos.Text = model.GetValue(iter, 3).ToString();
                //this.txtemail.Text = model.GetValue(iter, 4).ToString();

            }
        }


        protected void OnBtnEliminarClicked(object sender, EventArgs e)
        {
            int delete = 0;
            delete = dtservices.DeleteService(tservice);
            if (delete != 0)
            {
                var ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Info, ButtonsType.Ok, "Curso eliminado con exito!!!");
                ms.Run();
                ms.Destroy();
                CleanEntries();
                TrwModifyService.Model = dtservices.ListService();
            }
            else
            {
                var ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Error, ButtonsType.Ok, "Por favor selecione un curso e intente nuevamente!!!");
                ms.Run();
                ms.Destroy();
            }
        }



        protected void OnBtnActualizarClicked(object sender, EventArgs e)
        {
            if (txtname.Text.Equals("") || txtprice.Text.Equals(""))
            {
                var ms = new MessageDialog(null, DialogFlags.Modal,
                         MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos!!!");
                ms.Run();
                ms.Destroy();
            }
            else
            {
                tservice.Name = this.txtname.Text;
                tservice.Price = float.Parse(this.txtprice.Text);

                if (bservice.BSupdateCourseService(tservice))
                {

                    if (dtservices.UpdateService(tservice))
                    {

                        var ms = new MessageDialog(null, DialogFlags.Modal,
                         MessageType.Info, ButtonsType.Ok, "Se actualizó el usuario con éxito!!!");
                        ms.Run();
                        ms.Destroy();
                        CleanEntries();
                        TrwModifyService.Model = dtservices.ListService();
                    }

                    else
                    {

                        var ms = new MessageDialog(null, DialogFlags.Modal,
                            MessageType.Error, ButtonsType.Ok, "Seleccione un curso, revise los datos e intente nuevamente!!!");
                        ms.Run();
                        ms.Destroy();
                        this.txtname.GrabFocus();
                    }





                }

            }


        }


        protected void updateService(CourseService tservice)
        {
            if (bservice.BSupdateCourseService(tservice))
            {
                dtservices.UpdateService(tservice);
                var ms = new MessageDialog(null, DialogFlags.Modal,
                MessageType.Info, ButtonsType.Ok, "Se guardo el servicio con exito!!!");
                ms.Run();
                ms.Destroy();
                CleanEntries();
            }

        }


        public void CleanEntries()
        {
            txtprice.Text = "";
            txtname.Text = "";
            txtstate.Text = "";

        }//fin del metodo
    }



}

