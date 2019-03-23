using System;
using escuela_manejo.Data;

namespace escuela_manejo.Main_forms
{
    public partial class CoursesAdmin : Gtk.Window
    {
        public CoursesAdmin() :
                base(Gtk.WindowType.Toplevel)
        {
            var DTcoursesAdmin = new DTcoursesAdmin();
            this.Build();
        }
    }
}
