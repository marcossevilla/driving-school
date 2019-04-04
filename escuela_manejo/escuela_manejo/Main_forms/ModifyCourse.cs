using System;
using escuela_manejo.Data;
using Gtk;
using System.Text;
using escuela_manejo.business;

namespace escuela_manejo.Main_forms
{
    public partial class ModifyCourse : Gtk.Window
    {
        DTcourse dcour = new DTcourse();
        BScourse bcour = new BScourse();
        Course tcour = new Course();
        StringBuilder sb = new StringBuilder();

        public ModifyCourse() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            trwCourse.Model = dcour.ListCourse();
            string[] titulos = { "Id Curso", "Nombre", "Descripcion" };
            for (int i = 0; i < titulos.Length; i++)
            {
                trwCourse.AppendColumn(titulos[i], new CellRendererText(), "text", i);

            }

        }


        protected void OnTvwUsuariosCursorChanged(object sender, EventArgs e)
        {


            TreeSelection seleccion = (sender as TreeView).Selection;
            TreeIter iter;
            TreeModel model;
            if (seleccion.GetSelected(out model, out iter))
            {
                tcour.Id_course = Convert.ToInt32(model.GetValue(iter, 0).ToString());
                this.txtname.Text = model.GetValue(iter, 1).ToString();
                this.txtdes.Text = model.GetValue(iter, 2).ToString();
                //this.txtnombres.Text = model.GetValue(iter, 2).ToString();
                //this.txtapellidos.Text = model.GetValue(iter, 3).ToString();
                //this.txtemail.Text = model.GetValue(iter, 4).ToString();

            }
        }


        protected void OnBtnEliminarClicked(object sender, EventArgs e)
        {
            int delete = 0;
            delete = dcour.DeleteCour(tcour);
            if (delete != 0)
            {
                var ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Info, ButtonsType.Ok, "Curso eliminado con exito!!!");
                ms.Run();
                ms.Destroy();
                CleanEntries();
                trwCourse.Model = dcour.ListCourse();
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
            if (txtname.Text.Equals("") || txtdes.Text.Equals(""))
            {
                var ms = new MessageDialog(null, DialogFlags.Modal,
                         MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos!!!");
                ms.Run();
                ms.Destroy();
            }
            else
            {
                tcour.Name = this.txtname.Text;
                tcour.Description = this.txtdes.Text;

                if (bcour.BSupdateCourse(tcour))
                {

                    if (dcour.UpdateCour(tcour))
                    {

                        var ms = new MessageDialog(null, DialogFlags.Modal,
                         MessageType.Info, ButtonsType.Ok, "Se actualizó el usuario con éxito!!!");
                        ms.Run();
                        ms.Destroy();
                        CleanEntries();
                        trwCourse.Model = dcour.ListCourse();
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



        protected void updateCourse(Course Tcour)
        {
            if (bcour.BSupdateCourse(Tcour))
            {
                dcour.UpdateCour(Tcour);
                var ms = new MessageDialog(null, DialogFlags.Modal,
                MessageType.Info, ButtonsType.Ok, "Se guardo el usuario con exito!!!");
                ms.Run();
                ms.Destroy();
                CleanEntries();
            }

        }



        public void CleanEntries()
        {
            txtdes.Text = "";
            txtname.Text = "";

        }//fin del metodo

    }
      
}



