using System;
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



    }
}
