using System;
using escuela_manejo.Security_forms;
using escuela_manejo.Main_forms;
using Escuela_Manejo1;


namespace escuela_manejo.Main_forms
{
    public partial class Start : Gtk.Window
    {
        public Start() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected virtual void OnButtonCourseClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            CoursesAdmin Course = new CoursesAdmin();
            Course.Show();


        }


        protected virtual void OnButtonSecurityClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            Security_forms.SecurityAdmin sec = new SecurityAdmin();
            sec.Show();


        }


        protected virtual void OnButtonPaymentClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            drive.Payment pay = new drive.Payment();
            pay.Show();


        }

        protected virtual void OnButtonPaymentClients(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            drive.Payment pay = new drive.Payment();
            pay.Show();


        }

        protected virtual void OnButtonClients(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked


        }

        protected virtual void OnButtonVehicle(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            VehicleAdmin veh = new VehicleAdmin();
            veh.Show();

        }

        protected virtual void OnButtonClient(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            Escuela_Manejo1.Frm_Clientes client = new Frm_Clientes();
            client.Show();

        }


        protected virtual void OnButtonIns(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            Escuela_Manejo1.Frm_instructor ins = new Frm_instructor();
            ins.Show();

        }





    }
}
