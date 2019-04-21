using System;
using Gtk;
using escuela_manejo;
using escuela_manejo.Data;
using escuela_manejo.business;
using System.Collections.Generic;
namespace escuela_manejo.Main_forms
{
    public partial class AddService : Gtk.Window
    {
        CourseService tservices = new CourseService();
        Course tcourse = new Course();
        ServiceType tservicestype = new ServiceType();
        DTservice dtservice = new DTservice();
        DTcourse dtcourse = new DTcourse();
        DTservicetype dtru = new DTservicetype();
        BSservice BSservice = new BSservice();
        MessageDialog ms = null;

        Dictionary<string, int> namesAndID =  ///es de curso
         new Dictionary<string, int>();



        public AddService() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            //LLENAMOS LOS COMBOBOX
            Fillcombocourse();
            ///Fillcombostate();

            //POSICIONAMOS EL COMBO EN LA POSICION 0
            CleanCombos();
        }


        public void Fillcombocourse()
        {

            List<Course> listCourse = new List<Course>();
            listCourse = dtcourse.cbxCourse();



            combocourse.InsertText(0, "Seleccione...");

            foreach (Course tcourse in listCourse)
            {
                combocourse.InsertText(tcourse.Id_course, tcourse.Name);
                namesAndID.Add(tcourse.Name, tcourse.Id_course);
            }

        }

        public void CleanCombos()
        {
            //POSICIONAMOS EL COMBO EN LA POSICION 0
            this.combocourse.Active = 0;
            this.combostate.Active = 0;
        }

        protected void onClickBtnAddService(object sender, EventArgs e)
        {
            if (combocourse.Active == 0 || combostate.Active == 0)
            {
                ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos!!!");
                ms.Run();
                ms.Destroy();
            }
            else
            {
                var nameCourse = this.combocourse.ActiveText;

                foreach (KeyValuePair<string, int> name in namesAndID)
                {
                    if (nameCourse == name.Key)
                    {
                        tservices.Id_course_operating = name.Value;


                    }
                }


                tservices.Name = this.txtname.Text;
                tservices.Price = float.Parse(this.txtprice.Text);
                //tservices.Id_course_operating = dtservice.getIdcourse(this.combocourse.ActiveText);
                ///tservices.State = dtservice.getIdstate(this.combostate.ActiveText);

                if (BSservice.BSsaveService(tservices))
                {

                    ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Info, ButtonsType.Ok, "Se guardo el servicio con exito!!!");
                    ms.Run();
                    ms.Destroy();
                    //CleanEntries();
                }

                else
                {

                    ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, "Revise los datos e intente nuevamente!!!");
                    ms.Run();
                    ms.Destroy();
                    this.txtname.GrabFocus();
                }
            }

        }

    }
}
