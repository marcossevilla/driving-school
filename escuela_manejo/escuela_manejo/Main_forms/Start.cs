using System;
using escuela_manejo.Security_forms;



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
            Security_forms.SecurityAdmin sec = new SecurityAdmin() ;
            sec.Show();


        }


        protected virtual void OnButtonPaymentClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            drive.Payment pay = new drive.Payment();
            pay.Show();


        }





    }
}
