using System;
using escuela_manejo.Data;
using escuela_manejo.Business;
using escuela_manejo;
using Escuela_Manejo1;
using Gtk;
using System.Collections.Generic;
namespace escuela_manejo.Main_forms
{
    public partial class AddCourseInstance : Gtk.Window
    {
        Dictionary<string, int> namesAndID =  ///es de curso
         new Dictionary<string, int>();

        Dictionary<string, int> namesAndIdInstructor =
        new Dictionary<string, int>();

        Dictionary<string, int> namesAndIdClient =
        new Dictionary<string, int>();

        Dictionary<string, int> namesAndIdVeh =
        new Dictionary<string, int>();


        Course tbcourse = new Course();
        CourseOperating tbinscour = new CourseOperating();
        DTcourse dtcourse = new DTcourse();
        DTvehicle dtveh = new DTvehicle();
        BScourseOperating bscourseOperating = new BScourseOperating();


        Escuela_Manejo1.Datos.dtInstructor dtins = new Escuela_Manejo1.Datos.dtInstructor();
        Escuela_Manejo1.Datos.dtCliente dtclient = new Escuela_Manejo1.Datos.dtCliente();
        DTinstanceCourse dtinscour = new DTinstanceCourse();

        public AddCourseInstance() :
                base(Gtk.WindowType.Toplevel)
        {
            CourseOperating ins = new CourseOperating();
            this.Build();
            Fillcombocourse();
            Fillcomboins();
            Fillcomboveh();
            Fillcomboclient();
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


        public void Fillcomboins()
        {

            List<Escuela_Manejo1.entidades.Instructor> listInstructor = new List<Escuela_Manejo1.entidades.Instructor>();
            listInstructor = dtins.cbxIns();

            comboins.InsertText(0, "Seleccione...");

            foreach (Escuela_Manejo1.entidades.Instructor tins in listInstructor)
            {
                comboins.InsertText(tins.Id_instructor, tins.First_name);
                namesAndIdInstructor.Add(tins.First_name, tins.Id_instructor);
            }

        }



        public void Fillcomboveh()
        {

            List<Vehicle> listvehi = new List<Vehicle>();
            listvehi = dtveh.cbxState();

            comboveh.InsertText(0, "Seleccione...");

            foreach (Vehicle tveh in listvehi)
            {
                comboveh.InsertText(tveh.Id_vehicle, tveh.Plate);
                namesAndIdVeh.Add(tveh.Plate, tveh.Id_vehicle);
            }

        }



        public void Fillcomboclient()
        {

            List<Escuela_Manejo1.entidades.Customer> listclient = new List<Escuela_Manejo1.entidades.Customer>();
            listclient = dtclient.cbxCus();

            comboclient.InsertText(0, "Seleccione...");

            foreach (Escuela_Manejo1.entidades.Customer tcus in listclient)
            {
                comboclient.InsertText(tcus.Id_customer, tcus.First_name);
                namesAndIdClient.Add(tcus.First_name, tcus.Id_customer);
            }

        }





        protected void onClickBtnAddService(object sender, EventArgs e)
        {
            if (combocourse.Active == 0 || comboins.Active == 0 || comboveh.Active == 0 || comboclient.Active == 0)
            {
                var ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, "Todos los campos son requeridos!!!");
                ms.Run();
                ms.Destroy();
            }
            else
            {
                var nameCourse = this.combocourse.ActiveText;
                var nameIns = this.comboins.ActiveText;
                var nameVeh = this.comboveh.ActiveText;
                var nameClien = this.comboclient.ActiveText;


                foreach(KeyValuePair<string,int> name in namesAndID)
                {
                    if (nameCourse == name.Key)
                    {
                        tbinscour.Id_course = name.Value;


                    }
                }


                foreach (KeyValuePair<string, int> name in namesAndIdInstructor)
                {
                    if (nameIns == name.Key)
                    {
                        tbinscour.Id_instructor = name.Value;


                    }
                }


                foreach (KeyValuePair<string, int> name in namesAndIdVeh)
                {
                    if (nameVeh == name.Key)
                    {
                        tbinscour.Id_vehicle = name.Value;


                    }
                }

                foreach (KeyValuePair<string, int> name in namesAndIdClient)
                {
                    if (nameClien == name.Key)
                    {
                        tbinscour.Id_customer = name.Value;


                    }
                }


                //tbinscour.Id_instructor = this.comboins.Active;
                //tbinscour.Id_vehicle = this.comboveh.Active;
                //tbinscour.Id_customer = this.comboveh.Active;
                tbinscour.Start_date = calenIni.GetDate().ToString("yyyy-MM-dd HH:mm:ss");
                tbinscour.End_date= calenEnd.GetDate().ToString("yyyy-MM-dd HH:mm:ss");
                //createDialog(dateString);
                //dtservice.getIdcourse(this.combocourse.ActiveText);
                ///tservices.State = dtservice.getIdstate(this.combostate.ActiveText);

                if (bscourseOperating.BSsaveCourseOperating(tbinscour))
                {

                    var ms = new MessageDialog(null, DialogFlags.Modal,
                    MessageType.Info, ButtonsType.Ok, "Se guardo el servicio con exito!!!");
                    ms.Run();
                    ms.Destroy();
                    //CleanEntries();
                }

                else
                {

                    var ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, "Revise los datos e intente nuevamente!!!");
                    ms.Run();
                    ms.Destroy();
                    this.combocourse.GrabFocus();
                }
            }





         }


        protected MessageDialog createDialog(string message)
        {
            MessageDialog ms = null;
            ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, message);
            ms.Run();
            ms.Destroy();
            return ms;
        }
    }
}
