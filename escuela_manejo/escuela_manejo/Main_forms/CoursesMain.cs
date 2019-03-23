using System;



namespace escuela_manejo.Main_forms
{
    public partial class CoursesMain : Gtk.Window
    {
        public CoursesMain() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected virtual void OnButtonCoursesAdminClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            CoursesAdmin winCourAd = new CoursesAdmin();
            winCourAd.Show();


        }

        protected void C(object sender, EventArgs e)
        {
        }
    }
}
