using System;
using escuela_manejo.Data;
using escuela_manejo;
using escuela_manejo.business;
using Gtk;

namespace escuela_manejo.Main_forms
{
    public partial class AddCourse : Gtk.Window
    {
        Course cour = new Course();
        DTcourse dtCour = new DTcourse();
        BScourse bscourse = new BScourse();
        MessageDialog ms = null;

        public AddCourse() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        public void CleanEntries()
        {
            entryName.Text = "";
            entryDes.Text = "";

        }//fin del metodo


        protected void onClickBtnClean(object sender, EventArgs e)
        {
            CleanEntries();
        }//fin del metodo


        protected void OnBtnGuardarClicked(object sender, EventArgs e)
        {
            if (entryDes.Text.Equals("") || entryName.Text.Equals(""))
            {
                ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos!!!");
                ms.Run();
                ms.Destroy();
            }
            else
            {
                cour.Name = this.entryName.Text;
                cour.Description = this.entryDes.Text;

                if (bscourse.BSsaveUser(cour))
                    {

                        ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Info, ButtonsType.Ok, "Se guardo el usuario con exito!!!");
                        ms.Run();
                        ms.Destroy();
                        CleanEntries();
                    }

                    else
                    {

                        ms = new MessageDialog(null, DialogFlags.Modal,
                            MessageType.Error, ButtonsType.Ok, "Revise los datos e intente nuevamente!!!");
                        ms.Run();
                        ms.Destroy();
                        this.entryName.GrabFocus();
                    }
                }
              
            }
        }



    }
