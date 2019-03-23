using System;
namespace escuela_manejo.Main_forms

{
    public partial class Window : Gtk.Window
    {
        public Window() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected virtual void OnButtonCoursesClicked(object sender, System.EventArgs e)
        {
            //code executed when the button is clicked
            CoursesMain winCour = new CoursesMain();
            winCour.Show();


        }

    }
}
